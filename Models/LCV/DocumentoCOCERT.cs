using System;

namespace SimpleSDK.Models.LCV
{
    public class DocumentoCOCERT
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Rut contribuyente
        /// </summary>
        public string RutContribuyente { get; set; }

        /// <summary>
        /// TimeStamp de generación del firma.
        /// </summary>
        public DateTime FechaEmision { get; set; }

        /// <summary>
        /// Comprobante de autorización
        /// </summary>
        public CertificadoAutorizacionLibro ComprobanteAutorizacionLibro { get; set; }

        /// <summary>
        /// Rut firmante distribuidor.
        /// </summary>
        public string RutFirmanteDistribuidor { get; set; }

        /// <summary>
        /// TimeStamp de generación del firma.
        /// </summary>
        public DateTime FechaFirma { get; set; }
    }
}