using Newtonsoft.Json;
using SimpleSDK.Models.Extras;
using SimpleSDK.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSDK.Models.Estados
{
    public class ConsultaRecepcionDTE
    {
        /// <summary>
        /// Corresponde a los datos del certificado digital. Se debe indicar la ruta del archivo pfx y su contraseña.
        /// </summary>
        public CertificadoDigital Certificado { get; set; }
        private string _rutEmpresa { get; set; }
        private string _rutReceptor { get; set; }
        public long Folio { get; set; }
        public short Tipo { get; set; }
        public string RutEmpresa { get { return $"{RutEmpresaCuerpo}-{RutEmpresaDV}"; } }
        public string RutEmpresaCuerpo { get { return _rutEmpresa.Replace(".", "").Substring(0, _rutEmpresa.Replace(".", "").Length - 2); } }
        public string RutEmpresaDV { get { return _rutEmpresa.Substring(_rutEmpresa.Length - 1); } }
        public string RutReceptor { get { return $"{RutReceptorCuerpo}-{RutReceptorDV}"; } }
        public string RutReceptorCuerpo { get { return _rutReceptor.Substring(0, _rutReceptor.Length - 2); } }
        public string RutReceptorDV { get { return _rutReceptor.Substring(_rutReceptor.Length - 1); } }

        public ConsultaRecepcionDTE(string rutEmpresa, string rutReceptor)
        {
            _rutEmpresa = rutEmpresa;
            _rutReceptor = rutReceptor;
        }
        public Enum.Ambiente.AmbienteEnum Ambiente { get; set; }
        public bool ServidorBoletaREST { get; set; }
        public async Task<(bool, Models.Estados.StatusRecepcionResult)> ConsultarAlSII(string apikey)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();

                string inputContent = JsonConvert.SerializeObject(this);

                //Certificado
                var streamCert = new StreamContent(File.OpenRead(Certificado.Ruta));
                var certificadoByte = new ByteArrayContent(await streamCert.ReadAsByteArrayAsync());
                certificadoByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                certificadoByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = $"certificado_temp_{DateTime.Now.Ticks}.pfx"
                };

                HttpContent jsonString = new StringContent(inputContent);
                form.Add(jsonString, "input");
                form.Add(certificadoByte);

                var uriString = ApiBase.Url + $"consulta/recepcion";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                if(res.IsSuccessStatusCode)
                {
                    var content = await res.Content.ReadAsStreamAsync();
                    StreamReader reader = new StreamReader(content);
                    string xmlContent = reader.ReadToEnd();
                    var result = JsonConvert.DeserializeObject<StatusRecepcionResult>(xmlContent);
                    return (true, result);
                }
                else return (false, new StatusRecepcionResult() {  descripcion = res.ReasonPhrase });
               
            }
        }
    }
}
