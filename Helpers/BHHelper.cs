using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleSDK.Models.BHE;
using SimpleSDK.Models.RegistroCompraVentas;
using SimpleSDK.Services;

namespace SimpleSDK.Helpers
{
    public static class BHHelper
    {
        public static async Task<(bool, string)> EmitirAsync(BHData input, string apikey)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"BHE/emitir/";
                var bhDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", bhDataJson) };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));
                var res = await client.SendStandardRequestAsync(HttpMethod.Post, url, formData);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    return (false, "Ocurrió un error al emitir boleta de honorarios: " + contentString);
                }
                return (true, "");
            }
        }
        
        public static async Task<(bool, string)> AnularAsync(BasicData input, int folio, CausaAnulacionBHEnum motivo, string apikey)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"BHE/anular/{folio}/{motivo}/";
                var basicDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", basicDataJson) };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Post, url, formData);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    return (false, "Ocurrió un error al anular boleta de honorarios: " + contentString);
                }
                return (true, "");
            }
        }
        
        public static async Task<(bool, string)> EnviarEmail(BHData input, int folio, string apikey, int anio = 0)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"BHE/mail/{folio}/{anio}/";
                var basicDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", basicDataJson) };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Post, url, formData);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    return (false, "Ocurrió un error al enviar la boleta de honorarios electrónica por email: " + contentString);
                }
                return (true, "");
            }
        }
        
        public static async Task<byte[]> ObtenerPdfBoletaAsync(BHData input, string tipo, int folio, string apikey, int anio = 0)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"BHE/pdf/{tipo}/{folio}/{anio}/";
                var basicDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", basicDataJson) };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Post, url, formData);
                var fileStream = await res.Content.ReadAsStreamAsync();
                var memoryStream = new MemoryStream();
                await fileStream.CopyToAsync(memoryStream);
                byte[] pdfBytes = memoryStream.ToArray();
                if (!res.IsSuccessStatusCode)
                {
                    return null;
                }
                return pdfBytes;
            }
        }
        
        public static async Task<ResumenAnual> ObtenerListadoAnualAsync(BasicData input, string tipo, int anio, string apikey)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"BHE/listado/{tipo}/{anio}/";
                var basicDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", basicDataJson) };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, formData);
                var contentString = await res.Content.ReadAsStringAsync();
                var resumenAnual = JsonConvert.DeserializeObject<ResumenAnual>(contentString);
                if (!res.IsSuccessStatusCode)
                {
                    return null;
                }
                return resumenAnual;
            }
        }
        
        public static async Task<ResumenMensual> ObtenerListadoMensualAsync(BasicData input, string tipo, int anio, int mes, string apikey)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"BHE/listado/{tipo}/{mes}/{anio}/";
                var basicDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", basicDataJson) };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, formData);
                var contentString = await res.Content.ReadAsStringAsync();
                var resumenMensual = JsonConvert.DeserializeObject<ResumenMensual>(contentString);

                if (!res.IsSuccessStatusCode)
                {
                    return null;
                }
                return resumenMensual;
            }
        }
    }
}