using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using SimpleSDK.Models.RegistroCompraVentas;
using SimpleSDK.Services;

namespace SimpleSDK.Helpers
{
    public static class RCVHelper
    {
        public static async Task<(bool, RegistroComprasVentas)> ConsultaRegistroVentasAsync(DateTime date, bool mensual, RCVData rcvData, string apikey)
        {
            WinHttpHandler httpClientHandler = new WinHttpHandler() { ReceiveDataTimeout = TimeSpan.FromMinutes(10), ReceiveHeadersTimeout = TimeSpan.FromMinutes(10) };
            using (var client = new HttpClient(httpClientHandler))
            {
                client.BaseAddress = new Uri(ApiScraper.Url);
                var dia = date.Day;
                var mes = date.Month;
                var anio = date.Year;
                string url = client.BaseAddress + $"rcv/ventas/{dia}/{mes}/{anio}";
                if (mensual)
                    url = client.BaseAddress + $"rcv/ventas/{mes}/{anio}";
                
                var rcvDataJson = JsonConvert.SerializeObject(rcvData);
                var formData = new (string, string)[] { ("input", rcvDataJson) };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var input = JsonConvert.SerializeObject(rcvData);

                var multipartContent = new MultipartFormDataContent();
                var inputContent = new StringContent(input, Encoding.GetEncoding("ISO-8859-1"));
                var fileContent = new ByteArrayContent(rcvData.CertificadoB64);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-pkcs12");
                multipartContent.Add(fileContent, "file", "file");
                multipartContent.Add(inputContent, "input");

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, multipartContent);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    throw new Exception(res.ReasonPhrase + Environment.NewLine + contentString);
                }
                
                var registroCompraVenta = JsonConvert.DeserializeObject<RegistroComprasVentas>(contentString);
                return (true, registroCompraVenta);
            }
        }
        
        public static async Task<(bool, RegistroComprasVentas)> ConsultaRegistroComprasAsync(DateTime date, bool mensual, RCVData basicData, string apikey)
        {
            WinHttpHandler httpClientHandler = new WinHttpHandler() { ReceiveDataTimeout = TimeSpan.FromMinutes(10), ReceiveHeadersTimeout = TimeSpan.FromMinutes(10) };
            using (var client = new HttpClient(httpClientHandler))
            {
                client.BaseAddress = new Uri(ApiScraper.Url);
                var dia = date.Day;
                var mes = date.Month;
                var anio = date.Year;
                client.Timeout = TimeSpan.FromMinutes(3);
                string url = client.BaseAddress + $"rcv/compras/{dia}/{mes}/{anio}";
                if (mensual)
                    url = client.BaseAddress + $"rcv/compras/{mes}/{anio}";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var input = JsonConvert.SerializeObject(basicData);

                var multipartContent = new MultipartFormDataContent();
                var inputContent = new StringContent(input, Encoding.GetEncoding("ISO-8859-1"));
                var fileContent = new ByteArrayContent(basicData.CertificadoB64);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-pkcs12");
                multipartContent.Add(fileContent, "file", "file");
                multipartContent.Add(inputContent, "input");

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, multipartContent);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    throw new Exception(res.ReasonPhrase + Environment.NewLine + contentString);
                }

                
                var registroCompraVenta = JsonConvert.DeserializeObject<RegistroComprasVentas>(contentString);
                return (true, registroCompraVenta);
            }
        }
    }
}