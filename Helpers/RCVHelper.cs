using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
                
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Post, url, rcvData);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    throw new Exception(res.ReasonPhrase + Environment.NewLine + contentString);
                }
                
                var registroCompraVenta = JsonConvert.DeserializeObject<RegistroComprasVentas>(contentString);
                return (true, registroCompraVenta);
            }
        }
        
        public static async Task<(bool, RegistroComprasVentas)> ConsultaRegistroComprasAsync(DateTime date, bool mensual, RCVData rcvData, string apikey)
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

                var res = await client.SendStandardRequestAsync(HttpMethod.Post, url, rcvData);
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