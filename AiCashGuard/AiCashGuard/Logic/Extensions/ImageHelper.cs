using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace AiCashGuard.Logic.Extensions
{
    public class ImageHelper
    {
        public Image GetImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                using (Image image = Image.FromFile(imagePath))
                {
                    return new Bitmap(image);
                }
            }
            return null;
        }

        public string SaveImage(Image base64image, int id, string imageType)
        {
            //byte[] imageBytes = Convert.FromBase64String(base64image);
            string imagePath = GetImagePath(imageType) + id.ToString() + ".jpeg";

            if (File.Exists(imagePath))
            {
                // Delete the existing image
                File.Delete(imagePath);
            }

            /*using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                using (Image image = Image.FromStream(ms))
                {
                    image.Save(imagePath, ImageFormat.Jpeg);
                }
            }*/

            base64image.Save(imagePath, ImageFormat.Jpeg);

            return imagePath;
        }

        public static string GetImagePath(string imageType)
        {
            switch (imageType)
            {
                case "CUSTOMERIDFRONT":
                    return "D:\\Images\\CustomerIdFront\\";
                case "CUSTOMERIDBACK":
                    return "D:\\Images\\CustomerIdBack\\";
                case "CHECKIMAGE":
                    return "D:\\Images\\CheckImages\\";
                case "TRANSACTIONIMAGE":
                    return "D:\\Images\\TransactionImages\\";
                case "CUSTOMERFACE":
                    return "D:\\Images\\CustomerFaces\\";
                default:
                    return "No Path Found";
            }
        }
    }
}
