using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using SimpleSDK.Models.Folios;
using SimpleSDK.Services;

namespace SimpleSDK.Helpers
{
    public static class FoliosHelper
    {
        public static async Task<(bool response, string message, byte[] file)> ObtenerFolios(int cantidad, FoliosData input)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"Folios/get/{input.Tipo}/{cantidad}";

                var foliosDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", foliosDataJson) };

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, formData);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    return (false, "Ocurrió un error al obtener folios desde el sii: " + contentString, null);
                }
                var xml = new XmlDocument();
                xml.LoadXml(contentString);
                var file = Encoding.Default.GetBytes(xml.OuterXml);
                return (true, "Archivo descargado correctamente", file);
            }
        }
        
        public static async Task<(bool response, string message, int foliosDisponibles)> ConsultarMaximoFoliosDisponibles(FoliosData input)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"folios/get/{input.Tipo}";
                var foliosDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", foliosDataJson) };

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, formData);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    return (false, "Ocurrió un error al consultar folios desde el sii: " + contentString, 0);
                }
                var folios = JsonConvert.DeserializeObject<int>(contentString);
                var message = $"tiene {folios} folios disponibles";
                if(folios == 1) message = $"tiene {folios} folio disponible";
                if(folios == 0) message = $"no tiene folios disponibles";
                return (true, $"El rut {input.RutEmpresa} {message} del tipo {input.Tipo}", folios);
            }
        }
        
        public static async Task<(bool, string)> AnulacionMasiva(int desde, int hasta, FoliosData input)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"Folios/anulacion/masiva/{input.Tipo}/{desde}/{hasta}";
                var foliosDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", foliosDataJson) };

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, formData);
                var contentString = await res.Content.ReadAsStringAsync();
                if (!res.IsSuccessStatusCode)
                {
                    return (false, "Ocurrió un error al anular folios desde el sii: " + contentString);
                }
                return (true, "");
            }
        }
        
        public static async Task<(bool response, string message, InformacionFolios info)> ResumenFolios(DateTime desde, FoliosData input)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiRcv.Url);
                var url = client.BaseAddress + $"Folios/consulta/{input.Tipo}/{desde.ToString("dd-MM-yyyy")}";
                var foliosDataJson = JsonConvert.SerializeObject(input);
                var formData = new (string, string)[] { ("input", foliosDataJson) };

                var res = await client.SendStandardRequestAsync(HttpMethod.Get, url, formData);
                var contentString = await res.Content.ReadAsStringAsync();

                if (!res.IsSuccessStatusCode)
                {
                    return (false, "Ocurrió un error al consultar folios desde el sii: " + contentString, null);
                }
            
                var info = JsonConvert.DeserializeObject<InformacionFolios>(contentString);
                return (true,$"Información del tipo documento {input.Tipo} de la empresa rut {input.RutEmpresa}", info);
            }
        }
    }
}