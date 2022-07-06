using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSDK.Helpers
{
    public static class RequestBuilder
    {
        public static HttpRequestMessage RequestMessage(HttpMethod method, string uriString, object body)
        {
            var content = JsonConvert.SerializeObject(body);
            var buffer = Encoding.GetEncoding("ISO-8859-1").GetBytes(content);
            var requestContent = new ByteArrayContent(buffer);
            requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(uriString),
                Content = requestContent
            };
        }

        public static HttpRequestMessage RequestMessage(HttpMethod method, string uriString)
        {
            return new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(uriString)
            };
        }

        public static HttpRequestMessage RequestMessage(HttpMethod method, string uriString, (string, string)[] formData)
        {
            var requestContent =
                new FormUrlEncodedContent(formData.ToDictionary(t => t.Item1, t => t.Item2));
            return new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(uriString),
                Content = requestContent
            };
        }

        public static async Task<HttpResponseMessage> SendStandardRequestAsync(this HttpClient client, HttpMethod method, string uriString, (string, string)[] formData)
        {
            var message = RequestMessage(method, uriString, formData);
            return await client.SendAsync(message);
        }

        public static async Task<HttpResponseMessage> SendStandardRequestAsync(this HttpClient client, HttpMethod method, string uriString, object body = null)
        {
            HttpRequestMessage message;
            if (body != null)
                message = RequestMessage(method, uriString, body);
            else
                message = RequestMessage(method, uriString);
            return await client.SendAsync(message);
        }

        public static async Task<HttpResponseMessage> SendStandardRequestAsync(this HttpClient client, HttpMethod method, string uriString, KeyValuePair<string, string>[] formData)
        {
            var message = RequestMessage(method, uriString, formData);
            return await client.SendAsync(message);
        }


        public static async Task<HttpResponseMessage> SendStandardRequestAsync(this HttpClient client,
            HttpMethod method, string uriString, MultipartFormDataContent multipartFormDataContent)
        {
            var requestMessage = new HttpRequestMessage
            {
                Content = multipartFormDataContent,
                Method = method,
                RequestUri = new Uri(uriString),
            };
            return await client.SendAsync(requestMessage);
        } 
    }
}
