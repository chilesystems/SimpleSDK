using Newtonsoft.Json;
using SimpleSDK.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSDK.Models.Extras
{
    public class MuestraImpresa
    {
        public string FilePath { get; set; }

        public int NumeroResolucion { get; set; }
        public string UnidadSII { get; set; }
        public DateTime FechaResolucion { get; set; }
        public string Vendedor { get; set; }

        public string Hora { get; set; }

        /// <summary>
        /// Logo. Es Opcional. Debe ir en base64.
        /// </summary>
        public string LogoBase64 { get; set; }
        /// <summary>
        /// Timbre del PDF en base64. Es opcional. Si está vacío, la API lo genera
        /// </summary>
        public string TimbreBase64 { get; set; }
        /// <summary>
        /// Obtiene el timbre en base 64
        /// </summary>
        /// <returns></returns>
        public async Task<string> ObtenerTimbre(string apikey)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();

                //Archivo a validar
                var streamCert = new StreamContent(File.OpenRead(FilePath));
                var fileByte = new ByteArrayContent(await streamCert.ReadAsByteArrayAsync());
                fileByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                fileByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = $"file_temp_{DateTime.Now.Ticks}.xml"
                };
                form.Add(fileByte);

                var uriString = ApiBase.Url + $"pdf/timbre";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                var content = await res.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(content);
                TimbreBase64 = reader.ReadToEnd();

                return TimbreBase64;
            }
        }

        public async Task<(bool, string)> ObtenerMuestra(string apikey, string formato, string salida)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();
                string inputContent = JsonConvert.SerializeObject(this);

                //Archivo a validar
                var streamCert = new StreamContent(File.OpenRead(FilePath));
                var fileByte = new ByteArrayContent(await streamCert.ReadAsByteArrayAsync());
                fileByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                fileByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = $"file_temp_{DateTime.Now.Ticks}.xml"
                };

                HttpContent jsonString = new StringContent(inputContent);
                form.Add(jsonString, "input"); 
                form.Add(fileByte);

                var uriString = ApiBase.Url + $"impresion/{salida}/{formato}";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                var content = await res.Content.ReadAsStreamAsync();

                if (res.IsSuccessStatusCode)
                {
                    if (salida == "pdf")
                    {
                        using (var file = System.IO.File.Create($"dte_{DateTime.Now.Ticks}.pdf"))
                        {
                            await content.CopyToAsync(file); // copy that stream to the file stream
                            return (true, file.Name);
                        }
                    }
                    else if (salida == "base64")
                    {
                        StreamReader reader = new StreamReader(content);
                        string timbreContent = reader.ReadToEnd();

                        return (true, timbreContent);
                    }
                }
                return (false, "Ocurrió un error");               
            }
        }
    }
}
