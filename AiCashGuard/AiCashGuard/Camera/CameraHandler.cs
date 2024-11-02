using AiCashGuard.Model.Camera;
using System.Drawing;
using OpenCvSharp;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System.Collections.Concurrent;

namespace AiCashGuard.Camera
{
    public class CameraHandler
    {
        private static string url = "192.168.10.100:554";
        private static string username = "admin";
        private static string password = "123456";
        public static bool stopCapturing = false;
        public ImageModel customerImage;
        private ConcurrentStack<Mat> frameQueue = new ConcurrentStack<Mat>();

        // Construct the full URL with authentication
        private static string fullUrl = $"rtsp://{username}:{password}@{url}";

        // Load the face detection model (Haar Cascade)
        private static CascadeClassifier faceCascade = new CascadeClassifier("D:\\GitRepositories\\BW\\AiCashGuard\\AiCashGuard\\TrainModel\\haarcascade_frontalface_alt.xml");
        private static CascadeClassifier eyeCascade = new CascadeClassifier("D:\\GitRepositories\\BW\\AiCashGuard\\AiCashGuard\\TrainModel\\haarcascade_eye.xml");

        private static InferenceSession faceEmbedding = new InferenceSession("D:\\GitRepositories\\BW\\AiCashGuard\\AiCashGuard\\TrainModel\\arcface.onnx");

        public void stop(bool value)
        {
            stopCapturing = value;
        }

        public CameraHandler()
        {
        }

        public async Task CaptureFrame(bool onClick, Queue<ImageModel> imageList = null)
        {
            customerImage = new ImageModel();
            stopCapturing = false;

            using (var capture = new VideoCapture(fullUrl))
            {
                var abc = capture.Get(VideoCaptureProperties.Fps);
                capture.Set(VideoCaptureProperties.Fps, 1.0);
                capture.Set(VideoCaptureProperties.FrameWidth, 1920);
                capture.Set(VideoCaptureProperties.FrameHeight, 1080);

                if (!capture.IsOpened())
                {
                    stopCapturing = true;
                    throw new Exception("Could not open video capture.");
                }

                var captureFrameTask = Task.Run(() => CaptureFrames(capture));

                using (var grayFrame = new Mat())
                {
                    while (capture.IsOpened())
                    {
                        if (frameQueue.TryPop(out var originalFrame))
                        {
                            // Dispose of the previous frames in the queue (if any)
                            frameQueue.Clear();

                            // Using block to ensure proper disposal of originalFrame
                            using (originalFrame)
                            {
                                Cv2.CvtColor(originalFrame, grayFrame, ColorConversionCodes.BGRA2GRAY);
                                Cv2.EqualizeHist(grayFrame, grayFrame);
                                var faces = faceCascade.DetectMultiScale(grayFrame, minSize: new OpenCvSharp.Size(30, 30));

                                foreach (var faceRect in faces)
                                {
                                    using (var detectedFaceImage = new Mat(originalFrame, faceRect))
                                    using (var detectedFaceGrayImage = new Mat())
                                    {
                                        Cv2.CvtColor(detectedFaceImage, detectedFaceGrayImage, ColorConversionCodes.BGRA2GRAY);
                                        var faceeyes = eyeCascade.DetectMultiScale(detectedFaceGrayImage, minSize: new OpenCvSharp.Size(10, 10));

                                        if (faceeyes.Length == 2)
                                        {
                                            int margin = 50;
                                            int x = Math.Max(faceRect.X - margin, 0);
                                            int y = Math.Max(faceRect.Y - margin, 0);
                                            int width = Math.Min(faceRect.Width + 2 * margin, originalFrame.Cols - x);
                                            int height = Math.Min(faceRect.Height + 2 * margin, originalFrame.Rows - y);

                                            Rect faceWithMargin = new Rect(x, y, width, height);

                                            using (var faceROI = new Mat(originalFrame, faceWithMargin))
                                            {
                                                if (onClick)
                                                {
                                                    customerImage = new ImageModel
                                                    {
                                                        image = MatToBitmap(faceROI),
                                                        imageEmbed = ExtractFaceEmbedding(faceROI, faceEmbedding)
                                                    };
                                                    stopCapturing = true;
                                                    break;
                                                }
                                                else
                                                {
                                                    if (MicrosoftOynx(faceROI, imageList))
                                                    {
                                                        stopCapturing = true;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                Cv2.WaitKey(1);
                            }
                        }

                        if (stopCapturing)
                        {
                            break;
                        }
                    }
                }
                captureFrameTask.Wait();
            }
            Cv2.DestroyAllWindows();
        }

        private void CaptureFrames(VideoCapture capture)
        {
            while (!stopCapturing)
            {
                using (var frame = new Mat())
                {
                    if (stopCapturing)
                    {
                        break; // Exit the loop
                    }
                    capture.Read(frame);
                    if (!frame.Empty())
                    {
                        // Ensure the previous frame is properly disposed
                        if (frameQueue.Count > 2)
                        {
                            if (frameQueue.TryPop(out var oldFrame))
                            {
                                oldFrame.Dispose();
                            }
                        }
                        frameQueue.Push(frame.Clone()); // Clone to avoid issues with Mat disposal
                    }
                }
            }
        }

        private bool MicrosoftOynx(Mat frame, Queue<ImageModel> imageList)
        {
            var embedding = ExtractFaceEmbedding(frame, faceEmbedding);
            bool newFace = true;

            foreach (ImageModel item in imageList)
            {
                var similarity = CalculateCosineSimilarity(embedding, item.imageEmbed);

                if (similarity > 0.8)
                    newFace = false;
            }

            if (newFace)
            {
                customerImage = new ImageModel { image = MatToBitmap(frame), imageEmbed = embedding };
            }
            return newFace;
        }

        private static Bitmap MatToBitmap(Mat mat)
        {
            using (var ms = mat.ToMemoryStream())
            {
                return new Bitmap(ms);
            }
        }

        private static InferenceSession LoadModel()
        {
            return new InferenceSession("D:\\New\\CameraApp\\CameraApp\\arcface.onnx");
        }

        private static float[] ExtractFaceEmbedding(Mat image, InferenceSession model)
        {
            //using (var mat = Cv2.ImRead(imagePath))
            using (var resizedMat = new Mat())
            {
                Cv2.Resize(image, resizedMat, new OpenCvSharp.Size(112, 112));  // Resize to model input size
                var imageTensor = ImageToTensor(resizedMat);
                var inputs = new[] { NamedOnnxValue.CreateFromTensor("data", imageTensor) };

                using (var results = model.Run(inputs))
                {
                    var embeddingTensor = results.First().AsTensor<float>();

                    return embeddingTensor.ToArray();
                }
            }
        }

        private static Tensor<float> ImageToTensor(Mat image)
        {
            var height = image.Rows;
            var width = image.Cols;
            var channels = image.Channels();

            var floatArray = new float[height * width * channels];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var pixel = image.Get<Vec3b>(y, x);
                    floatArray[(y * width + x) * channels + 0] = pixel.Item2 / 255.0f;  // B
                    floatArray[(y * width + x) * channels + 1] = pixel.Item1 / 255.0f;  // G
                    floatArray[(y * width + x) * channels + 2] = pixel.Item0 / 255.0f;  // R
                }
            }

            var tensor = new DenseTensor<float>(floatArray, new[] { 1, channels, height, width });
            return tensor;
        }

        private static float CalculateCosineSimilarity(float[] features1, float[] features2)
        {
            var dotProduct = features1.Zip(features2, (a, b) => a * b).Sum();
            var normA = Math.Sqrt(features1.Sum(x => x * x));
            var normB = Math.Sqrt(features2.Sum(x => x * x));
            return (float)(dotProduct / (normA * normB));
        }
    }
}
