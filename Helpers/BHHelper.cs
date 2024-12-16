using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BHE.Models;
using Newtonsoft.Json;
using SimpleSDK.Models.BHE;
using SimpleSDK.Models.RegistroCompraVentas;
using SimpleSDK.Services;

namespace SimpleSDK.Helpers
{
    public static class BHHelper
    {
        public static async Task<(bool, string, EmisionBoleta)> EmitirAsync(BHData input, bool isTerceros, string apikey)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiScraper.Url);
                string url = string.Empty;
                if (isTerceros)
                {
                    url = client.BaseAddress + $"BHE/terceros/emitir/";
                }else
                {
                    url = client.BaseAddress + $"BHE/emitir/";
                }
                
                //var bhDataJson = JsonConvert.SerializeObject(input);
                //var formData = new (string, string)[] { ("input", bhDataJson) };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));
                var res = await client.SendStandardRequestAsync(HttpMethod.Post, url, input);
                if (res.IsSuccessStatusCode)
                {
                    var contentString = await res.Content.ReadAsStringAsync();
                    var emisioBoleta = JsonConvert.DeserializeObject<EmisionBoleta>(contentString);
                    return (res.IsSuccessStatusCode, string.Empty, emisioBoleta);
                }
                else
                {
                    var contentString = await res.Content.ReadAsStringAsync();
                    return (res.IsSuccessStatusCode, contentString, null);
                }
            }
        }
        
        public static async Task<(bool, string)> AnularAsync(BasicData input, int folio, CausaAnulacionBHEnum motivo, string apikey)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiScraper.Url);
                var url = client.BaseAddress + $"BHE/anular/{folio}/{motivo}/";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Post, url, input);
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
                client.BaseAddress = new Uri(ApiScraper.Url);
                var url = client.BaseAddress + $"BHE/mail/{folio}/{anio}/";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Post, url, input);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    return (false, "Ocurrió un error al enviar la boleta de honorarios electrónica por email: " + contentString);
                }
                return (true, contentString);
            }
        }
        
        public static async Task<byte[]> ObtenerPdfBoletaAsync(BHData input, string tipo, int folio, string apikey, int anio = 0)
        {
            WinHttpHandler httpClientHandler = new WinHttpHandler() { ReceiveDataTimeout = TimeSpan.FromMinutes(10), ReceiveHeadersTimeout = TimeSpan.FromMinutes(10) };
            using (var client = new HttpClient(httpClientHandler))
            {
                client.BaseAddress = new Uri(ApiScraper.Url);
                var url = client.BaseAddress + $"BHE/pdf/{tipo}/{folio}/{anio}/";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, input);
                var fileStream = await res.Content.ReadAsStreamAsync();
                var memoryStream = new MemoryStream();
                await fileStream.CopyToAsync(memoryStream);
                byte[] pdfBytes = memoryStream.ToArray();
                if (!res.IsSuccessStatusCode)
                {
                    throw new Exception(res.ReasonPhrase);
                }
                return pdfBytes;
            }
        }
        
        public static async Task<ResumenAnual> ObtenerListadoAnualAsync(BasicData input, string tipo, int anio, string apikey)
        {
            WinHttpHandler httpClientHandler = new WinHttpHandler() { ReceiveDataTimeout = TimeSpan.FromMinutes(10), ReceiveHeadersTimeout = TimeSpan.FromMinutes(10) };
            using (var client = new HttpClient(httpClientHandler))
            {
                client.BaseAddress = new Uri(ApiScraper.Url);
                var url = client.BaseAddress + $"BHE/listado/{tipo}/{anio}/";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, input);
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
            WinHttpHandler httpClientHandler = new WinHttpHandler() { ReceiveDataTimeout = TimeSpan.FromMinutes(10), ReceiveHeadersTimeout = TimeSpan.FromMinutes(10) };

            using (var client = new HttpClient(httpClientHandler))
            {
                client.BaseAddress = new Uri(ApiScraper.Url);
                var url = client.BaseAddress + $"BHE/listado/{tipo}/{mes}/{anio}/";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, input);
                var contentString = await res.Content.ReadAsStringAsync();
                var resumenMensual = JsonConvert.DeserializeObject<ResumenMensual>(contentString);

                if (!res.IsSuccessStatusCode)
                {
                    return null;
                }
                return resumenMensual;
            }
        }

        public static async Task<RegionesData> ObtenerListaComunasAsync(string apikey)
        {
            WinHttpHandler httpClientHandler = new WinHttpHandler()
            {
                ReceiveDataTimeout = TimeSpan.FromMinutes(5),
                ReceiveHeadersTimeout = TimeSpan.FromMinutes(5)
            };

            using (var client = new HttpClient(httpClientHandler))
            {
                client.BaseAddress = new Uri(ApiScraper.Url);
                var url = client.BaseAddress + "BHE/listarComunas/";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.GetAsync(url);

                if (!res.IsSuccessStatusCode)
                {
                    var errorContent = await res.Content.ReadAsStringAsync();
                    
                    throw new Exception($"Error al obtener la lista de comunas: {res.StatusCode} - {errorContent}");
                }

                var contentString = await res.Content.ReadAsStringAsync();
                var regionesData = JsonConvert.DeserializeObject<RegionesData>(contentString);

                return regionesData;
            }
        }

    }
}