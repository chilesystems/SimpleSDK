using Newtonsoft.Json;
using SimpleSDK.Models.Estados;
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
    public class Validador
    {
        public SimpleSDK.Enum.TipoEnvio.ValidacionType Tipo { get; set; }
        public string FilePath { get; set; }

        public async Task<string> ConsultarAlSII(string apikey)
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

                var uriString = ApiBase.Url + $"consulta/validador";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                var content = await res.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(content);
                string xmlContent = reader.ReadToEnd();

                return xmlContent;
            }
        }
    }
}
