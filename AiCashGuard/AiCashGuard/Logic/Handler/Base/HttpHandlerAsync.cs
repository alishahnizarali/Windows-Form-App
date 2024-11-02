using System;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AiCashGuard.Logic.Handler.Base
{
    public class HttpHandlerAsync
    {
        private static HttpClient httpClient = new HttpClient();
        public static async Task<string> ProcessRequest(baseRequestProperties baseReq)
        {
            try
            {
                if (!string.IsNullOrEmpty(baseReq.url))
                {
                    baseReq.url = baseReq.url.TrimEnd();
                    if (baseReq.url[baseReq.url.Length - 1] != '/')
                        baseReq.url += '/';

                    baseReq.url += baseReq.resource.TrimEnd();

                }

                if (baseReq.method == null)
                    baseReq.method = HttpMethod.Get;

                var HttpRequest = new HttpRequestMessage(baseReq.method, baseReq.url);
                HttpRequest.Version = HttpVersion.Version10;
                HttpRequest.Headers.Accept.Clear();

                if (baseReq.IsAuthentication)
                    HttpRequest.Headers.Add("Authorization", baseReq.HeaderAuth);

                // Setup header(s)
                HttpRequest.Headers.Add("Accept", "application/json");
                // Add body content
                if (baseReq.method == HttpMethod.Post || baseReq.method == HttpMethod.Put)
                {
                    HttpRequest.Content = new StringContent(
                        baseReq.requestData,
                        Encoding.UTF8,
                        "application/json"
                    );
                    HttpRequest.Content.Headers.ContentType.CharSet = "";
                }

                using (var response = await httpClient.SendAsync(HttpRequest))
                {
                    if (response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.Created)
                    { throw new Exception(response.ToString()); }

                    var strResult = await response.Content.ReadAsStringAsync();
                    HttpRequest?.Dispose();
                    return strResult;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public class baseRequestProperties
        {
            public string messageId { get; set; }
            public bool IsAuthentication { get; set; }
            public bool LoggingEnabled { get; set; }
            public string url { get; set; }
            public string url_param { get; set; }
            public HttpMethod method { get; set; }
            public string HeaderAuth { get; set; }
            public string resource { get; set; }
            public string requestData { get; set; }
            public string querystring { get; set; }
        }
    }
}
