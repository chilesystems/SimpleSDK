using Newtonsoft.Json;
using SimpleSDK.Enum;
using SimpleSDK.Models.DTE;
using SimpleSDK.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSDK.Helpers
{
    public static class DTEExtensions
    {
        /// <summary>
        /// Obtiene el XML en codificación ISO-8859-1
        /// </summary>
        /// <param name="dte">Objeto que se transformará en XML</param>
        /// <param name="pathCAF">Ruta al archivo CAF que permite el timbraje</param>
        /// <param name="apikey">Código de autorización. Puedes obtener uno en www.simple-api.cl</param>
        /// <returns>Tupla (bool, string). El primer argumento indica si la operación fue exitosa. El segundo el mensaje del resultado</returns>
        public static async Task<(bool, string)> GenerarXMLAsync(this DTE dte, string pathCAF, string apikey)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();

                string inputContent = JsonConvert.SerializeObject(dte);

                //Certificado
                var streamCert = new StreamContent(File.OpenRead(dte.Certificado.Ruta));
                var certificadoByte = new ByteArrayContent(await streamCert.ReadAsByteArrayAsync());
                certificadoByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                certificadoByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = $"certificado_temp_{DateTime.Now.Ticks}.pfx"
                };

                //Archivo CAF
                var streamCAF = new StreamContent(File.OpenRead(pathCAF));
                var cafByte = new ByteArrayContent(await streamCAF.ReadAsByteArrayAsync());
                cafByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                cafByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = $"archivo_caf_{DateTime.Now.Ticks}.xml"
                };

                HttpContent jsonString = new StringContent(inputContent);
                form.Add(jsonString, "input");
                form.Add(certificadoByte);
                form.Add(cafByte);

                //var formData = new[] { ("input",  dteContent), ("file1", dte.Certificado.Ruta), ("file2", pathCAF) };

                var uriString = ApiBase.Url + "dte/generar";
                //var message = RequestBuilder.RequestMessage(HttpMethod.Post, uriString, formData);
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                var content = await res.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(content, Encoding.GetEncoding("ISO-8859-1"));
                string xmlResultante = reader.ReadToEnd();

                return res.IsSuccessStatusCode ? (true, xmlResultante) : (false, string.IsNullOrEmpty(xmlResultante) ? res.ReasonPhrase : xmlResultante);
            }
        }

        /// <summary>
        /// Obtiene el XML en codificación ISO-8859-1
        /// </summary>
        /// <param name="aec">Objeto que se transformará en XML</param>
        /// <param name="pathDTE">Ruta al archivo DTE que se está cediendo</param>
        /// <param name="apikey">Código de autorización. Puedes obtener uno en www.simple-api.cl</param>
        /// <returns>Tupla (bool, string). El primer argumento indica si la operación fue exitosa. El segundo el mensaje del resultado</returns>
        public static async Task<(bool, string)> GenerarXMLAsync(this Models.Cesion.AEC aec, string pathDTE, string apikey)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();

                string inputContent = JsonConvert.SerializeObject(aec);

                //Certificado
                var streamCert = new StreamContent(File.OpenRead(aec.Certificado.Ruta));
                var certificadoByte = new ByteArrayContent(await streamCert.ReadAsByteArrayAsync());
                certificadoByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                certificadoByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = $"certificado_temp_{DateTime.Now.Ticks}.pfx"
                };

                //Archivo XML: DTE Cedido
                var streamDTE = new StreamContent(File.OpenRead(pathDTE));
                var dteByte = new ByteArrayContent(await streamDTE.ReadAsByteArrayAsync());
                dteByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                dteByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = "dte_cedido.xml"
                };

                HttpContent jsonString = new StringContent(inputContent);
                form.Add(jsonString, "input");
                form.Add(certificadoByte);
                form.Add(dteByte);

                var uriString = ApiBase.Url + "dte/cesion/generar";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                var content = await res.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(content, Encoding.GetEncoding("ISO-8859-1"));
                string xmlResultante = reader.ReadToEnd();

                return res.IsSuccessStatusCode ? (true, xmlResultante) : (false, string.IsNullOrEmpty(xmlResultante) ? res.ReasonPhrase : xmlResultante);
            }
        }
        /// <summary>
        /// Obtiene el XML en codificación ISO-8859-1
        /// </summary>
        /// <param name="envio">Objeto que se transformará en XML</param>
        /// <param name="pathDTEs">Ruta de los DTE que se enviarán al SII</param>
        /// <param name="apikey">Código de autorización. Puedes obtener uno en www.simple-api.cl</param>
        /// <returns></returns>
        public static async Task<(bool, string)> GenerarXMLAsync(this Models.Envios.SobreEnvio envio, string[] pathDTEs, string apikey)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();

                string inputContent = JsonConvert.SerializeObject(envio);

                //Certificado
                var streamCert = new StreamContent(File.OpenRead(envio.Certificado.Ruta));
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

                //Archivos XML a ser enviados
                foreach (var pathDTE in pathDTEs)
                {
                    var streamDTE = new StreamContent(File.OpenRead(pathDTE));
                    var dteByte = new ByteArrayContent(await streamDTE.ReadAsByteArrayAsync());
                    dteByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    dteByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                    {
                        Name = "file",
                        FileName = $"archivo_dte_{DateTime.Now.Ticks}.xml"
                    };
                    form.Add(dteByte);
                }

                var uriString = ApiBase.Url + $"envio/generar";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                var content = await res.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(content, Encoding.GetEncoding("ISO-8859-1"));
                string xmlResultante = reader.ReadToEnd();

                return res.IsSuccessStatusCode ? (true, xmlResultante) : (false, string.IsNullOrEmpty(xmlResultante) ? res.ReasonPhrase : xmlResultante);
            }
        }

        /// <summary>
        /// Obtiene el XML en codificación ISO-8859-1
        /// </summary>
        /// <param name="rcof">Objeto que se transformará en XML</param>
        /// <param name="apikey">Código de autorización. Puedes obtener uno en www.simple-api.cl</param>
        /// <returns></returns>
        public static async Task<(bool, string)> GenerarXMLAsync(this Models.RCOF.ConsumoFolios rcof, string apikey)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();

                string inputContent = JsonConvert.SerializeObject(rcof);

                //Certificado
                var streamCert = new StreamContent(File.OpenRead(rcof.Certificado.Ruta));
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

                var uriString = ApiBase.Url + $"rcof/generar";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                var content = await res.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(content, Encoding.GetEncoding("ISO-8859-1"));
                string xmlResultante = reader.ReadToEnd();

                return res.IsSuccessStatusCode ? (true, xmlResultante) : (false, string.IsNullOrEmpty(xmlResultante) ? res.ReasonPhrase : xmlResultante);
            }
        }

        /// <summary>
        /// Obtiene el XML en codificación ISO-8859-1
        /// </summary>
        /// <param name="libro">Objeto que se transformará en XML</param>
        /// <param name="apikey">Código de autorización. Puedes obtener uno en www.simple-api.cl</param>
        /// <returns></returns>
        public static async Task<(bool, string)> GenerarXMLAsync(this Models.LCV.LibroGuia libro, string apikey)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();

                string inputContent = JsonConvert.SerializeObject(libro);

                //Certificado
                var streamCert = new StreamContent(File.OpenRead(libro.Certificado.Ruta));
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

                var uriString = ApiBase.Url + $"lcv/libroguia/generar";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                var content = await res.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(content, Encoding.GetEncoding("ISO-8859-1"));
                string xmlResultante = reader.ReadToEnd();

                return res.IsSuccessStatusCode ? (true, xmlResultante) : (false, string.IsNullOrEmpty(xmlResultante) ? res.ReasonPhrase : xmlResultante);
            }
        }

        public static async Task<(bool, Models.Envios.EnvioResult)> EnviarSIIAsync(this Models.Envios.EnvioSII envio, string pathEnvio, string apikey)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();

                string inputContent = JsonConvert.SerializeObject(envio);

                //Certificado
                var streamCert = new StreamContent(File.OpenRead(envio.Certificado.Ruta));
                var certificadoByte = new ByteArrayContent(await streamCert.ReadAsByteArrayAsync());
                certificadoByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                certificadoByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = $"certificado_temp_{DateTime.Now.Ticks}.pfx"
                };

                //Archivo XML: DTE Cedido
                var streamEnvio = new StreamContent(File.OpenRead(pathEnvio));
                var envioByte = new ByteArrayContent(await streamEnvio.ReadAsByteArrayAsync());
                envioByte.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                envioByte.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = $"envio_sii_{DateTime.Now.Ticks}.xml"
                };

                HttpContent jsonString = new StringContent(inputContent);
                form.Add(jsonString, "input");
                form.Add(certificadoByte);
                form.Add(envioByte);

                var uriString = ApiBase.Url + $"envio/enviar";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);

                if (res.IsSuccessStatusCode)
                {
                    var content = await res.Content.ReadAsStreamAsync();
                    StreamReader reader = new StreamReader(content);
                    string xmlContent = reader.ReadToEnd();
                    var result = JsonConvert.DeserializeObject<Models.Envios.EnvioResult>(xmlContent);

                    return (res.IsSuccessStatusCode, result);
                }
                else return (false, new Models.Envios.EnvioResult() { ResponseXml = await res.Content.ReadAsStringAsync() });

            }
        }

        public static async Task<(bool, Models.Estados.EstadoDTEResult)> ConsultarAlSII(this Models.Estados.ConsultaDTE consulta, string apikey)
        {
            using (var client = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();

                string inputContent = JsonConvert.SerializeObject(consulta);

                //Certificado
                var streamCert = new StreamContent(File.OpenRead(consulta.Certificado.Ruta));
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

                var uriString = ApiBase.Url + $"estado/dte";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apikey}")));

                var res = await client.PostAsync(uriString, form);
                var content = await res.Content.ReadAsStreamAsync();
                StreamReader reader = new StreamReader(content);
                string xmlContent = reader.ReadToEnd();

                var result = JsonConvert.DeserializeObject<Models.Estados.EstadoDTEResult>(xmlContent);

                return (res.IsSuccessStatusCode, result);
            }
        }


        /// <summary>
        /// Calcula el monto Exento, Neto, IVA y Total de un DTE según sus detalles. El descuento debe ir en porcentaje para que lo calcule.
        /// </summary>
        /// <param name="dte">DTE a calcular sus totales.</param>
        public static void CalcularTotales(this DTE dte)
        {
            //DOCUMENTO - ENCABEZADO - TOTALES - CAMPOS OBLIGATORIOS
            if (dte.Documento.Encabezado.IdentificacionDTE.TipoDTE != TipoDTE.DTEType.BoletaElectronica
                && dte.Documento.Encabezado.IdentificacionDTE.TipoDTE != TipoDTE.DTEType.BoletaElectronicaExenta)
            {
                dte.Documento.Encabezado.Totales.TasaIVA = Convert.ToDouble(19);
                var neto = dte.Documento.Detalles
                    .Where(x => x.IndicadorExento == IndicadorFacturacionExencionEnum.NotSet)
                    .Sum(x => x.MontoItem);

                var exento = dte.Documento.Detalles
                    .Where(x => x.IndicadorExento == IndicadorFacturacionExencionEnum.NoAfectoOExento)
                    .Sum(x => x.MontoItem);

                var descuentoPorcentaje = dte.Documento.DescuentosRecargos?
                    .Where(x => x.TipoMovimiento == TipoMovimiento.TipoMovimientoEnum.Descuento
                    && x.TipoValor == ExpresionDinero.ExpresionDineroEnum.Porcentaje)
                    .Sum(x => x.Valor);

                var descuentoPesos = dte.Documento.DescuentosRecargos?
                    .Where(x => x.TipoMovimiento == TipoMovimiento.TipoMovimientoEnum.Descuento
                    && x.TipoValor == ExpresionDinero.ExpresionDineroEnum.Pesos)
                    .Sum(x => x.Valor);

                if(descuentoPorcentaje.Value > 0 && descuentoPesos.Value > 0) throw new Exception("No se puede tener un descuento en porcentaje y pesos al mismo tiempo.");
                if (descuentoPorcentaje.HasValue && descuentoPorcentaje.Value > 0)
                {
                    var montoDescuentoAfecto = (int)Math.Round(neto * (descuentoPorcentaje.Value / 100), 0, MidpointRounding.AwayFromZero);
                    neto -= montoDescuentoAfecto;
                }
                else if (descuentoPesos.HasValue && descuentoPesos.Value > 0) 
                { 
                    neto -= (int)descuentoPesos.Value;
                }
                var iva = (int)Math.Round(neto * 0.19, 0);
                int retenido = 0;

                if (dte.Documento.Detalles.Any(x => x.CodigoImpuestoAdicional != null))
                {
                    retenido = (int)Math.Round(
                        dte.Documento.Detalles
                        .Where(x => x.CodigoImpuestoAdicional.First() == TipoImpuesto.TipoImpuestoEnum.IVARetenidoTotal)
                        .Sum(x => x.MontoItem) * 0.19, 0);

                    if (retenido != 0)
                    {
                        dte.Documento.Encabezado.Totales.ImpuestosRetenciones = new List<ImpuestosRetenciones>
                        {
                            new ImpuestosRetenciones()
                            {
                                MontoImpuesto = retenido,
                                TasaImpuesto = 19,
                                TipoImpuesto = TipoImpuesto.TipoImpuestoEnum.IVARetenidoTotal
                            }
                        };
                    }
                }

                dte.Documento.Encabezado.Totales.MontoNeto = neto;
                dte.Documento.Encabezado.Totales.MontoExento = exento;
                dte.Documento.Encabezado.Totales.IVA = iva;
                dte.Documento.Encabezado.Totales.MontoTotal = neto + exento + iva - retenido;
            }
            else
            {
                /*En las boletas, sólo es necesario informar el monto total*/
                if (dte.Documento.Encabezado.IdentificacionDTE.TipoDTE == TipoDTE.DTEType.BoletaElectronica)
                {
                    var totalBrutoAfecto = dte.Documento.Detalles
                    .Where(x => x.IndicadorExento == IndicadorFacturacionExencionEnum.NotSet)
                    .Sum(x => x.MontoItem);

                    var totalExento = dte.Documento.Detalles
                        .Where(x => x.IndicadorExento == IndicadorFacturacionExencionEnum.NoAfectoOExento)
                        .Sum(x => x.MontoItem);

                    var descuentos = dte.Documento.DescuentosRecargos?
                       .Where(x => x.TipoMovimiento == TipoMovimiento.TipoMovimientoEnum.Descuento
                       && x.TipoValor == ExpresionDinero.ExpresionDineroEnum.Porcentaje)
                       .Sum(x => x.Valor);

                    var neto = totalBrutoAfecto / 1.19;

                    if (descuentos.HasValue && descuentos.Value > 0)
                    {
                        var montoDescuentoAfecto = (int)Math.Round(neto * (descuentos.Value / 100), 0, MidpointRounding.AwayFromZero);
                        neto -= montoDescuentoAfecto;
                    }


                    var iva = (int)Math.Round(neto * 0.19, 0, MidpointRounding.AwayFromZero);
                    dte.Documento.Encabezado.Totales.IVA = iva;
                    dte.Documento.Encabezado.Totales.MontoNeto = (int)Math.Round(neto, 0, MidpointRounding.AwayFromZero);
                    dte.Documento.Encabezado.Totales.MontoTotal = dte.Documento.Encabezado.Totales.MontoNeto + totalExento + iva;
                }
                else //Boleta electrónica exenta
                {
                    var total = dte.Documento.Detalles.Sum(x => x.MontoItem);
                    dte.Documento.Encabezado.Totales.MontoExento = dte.Documento.Encabezado.Totales.MontoTotal = total;
                }

            }

        }

        /// <summary>
        /// Calcula el monto  Total de un DTE de exportacion. según sus detalles.
        /// </summary>
        /// <param name="dte">DTE a calcular sus totales.</param>
        public static void CalcularTotalesExportacion(this DTE dte, CodigosAduana.Moneda moneda)
        {
            var exento = dte.Exportaciones.Detalles
                .Where(x => x.IndicadorExento == IndicadorFacturacionExencionEnum.NoAfectoOExento)
                .Sum(x => x.MontoItem);

            dte.Exportaciones.Encabezado.Totales.MontoExento = (int)Math.Round(exento, 0, MidpointRounding.AwayFromZero);
            dte.Exportaciones.Encabezado.Totales.MontoTotal = dte.Exportaciones.Encabezado.Totales.MontoExento;
            dte.Exportaciones.Encabezado.Totales.TipoMoneda = moneda;
        }

       
    }
}
