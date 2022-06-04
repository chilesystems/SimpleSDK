using System;
using System.Linq;
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
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var dia = date.Day;
                var mes = date.Month;
                var anio = date.Year;
                string url = client.BaseAddress + $"ventas/{dia}/{mes}/{anio}";
                if (mensual)
                    url = client.BaseAddress + $"ventas/{mes}/{anio}";
                
                var rcvDataJson = JsonConvert.SerializeObject(rcvData);
                var formData = new (string, string)[] { ("input", rcvDataJson) };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));
            
                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, formData);

                if (!res.IsSuccessStatusCode)
                {
                    return (false, null);
                }

                var contentString = await res.Content.ReadAsStringAsync();
                var registroCompraVenta = JsonConvert.DeserializeObject<RegistroComprasVentas>(contentString);
                return (true, registroCompraVenta);
            }
        }
        
        public static async Task<(bool, RegistroComprasVentas)> ConsultaRegistroComprasAsync(DateTime date, bool mensual, RCVData basicData, string apikey)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var dia = date.Day;
                var mes = date.Month;
                var anio = date.Year;
                string url = client.BaseAddress + $"compras/{dia}/{mes}/{anio}";
                if (mensual)
                    url = client.BaseAddress + $"compras/{mes}/{anio}";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var input = JsonConvert.SerializeObject(basicData);
                var formData = new (string, string)[] { ("input", input) };
                FormUrlEncodedContent requestContent = new FormUrlEncodedContent(formData.ToDictionary(t => t.Item1, t => t.Item2));
                HttpRequestMessage message = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url),
                    Content = requestContent
                };
                var res = await client.SendAsync(message);
                if (!res.IsSuccessStatusCode)
                {
                    return (false, null);
                }

                var contentString = await res.Content.ReadAsStringAsync();
                var registroCompraVenta = JsonConvert.DeserializeObject<RegistroComprasVentas>(contentString);
                return (true, registroCompraVenta);
            }
        }
    }
}