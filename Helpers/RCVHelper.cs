using System;
using System.IO;
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
        public static async Task<(bool, RegistroComprasVentas)> ConsultaRegistroVentasAsync(this RegistroComprasVentas registroComprasVentas, DateTime date, bool mensual, RCVData rcvData, string apikey)
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
        
        public static async Task<(bool, RegistroComprasVentas)> ConsultaRegistroComprasAsync(this RegistroComprasVentas registroComprasVentas, DateTime date, bool mensual, RCVData basicData, string apikey)
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

                string inputContent = JsonConvert.SerializeObject(basicData);
                var rcvDataJson = JsonConvert.SerializeObject(basicData);
                var formData = new (string, string)[] { ("input", rcvDataJson) };
            
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
    }
}