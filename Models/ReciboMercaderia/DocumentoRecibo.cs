using System;

namespace SimpleSDK.Models.ReciboMercaderia
{
    public class DocumentoRecibo
    {
        public string Id { get; set; }

        /// <summary>
        /// Tipo de documento
        /// </summary>
        public Enum.TipoDTE.DTEType TipoDocumento { get; set; }

        /// <summary>
        /// Folio del documento
        /// </summary>
        public long Folio { get; set; }

        /// <summary>
        /// Fecha emision contable del DTE.
        /// </summary>
        public DateTime FechaEmision { get; set; }

        /// <summary>
        /// Rut emisor del documento
        /// </summary>
        public string RutEmisor { get; set; }

        /// <summary>
        /// Rut receptor del documento
        /// </summary>
        public string RutReceptor { get; set; }

        /// <summary>
        /// Monto total del documento
        /// </summary>
        public int MontoTotal { get; set; }
        /// <summary>
        /// Lugar donde se realiza la recepción conforme
        /// </summary>
        public string Recinto { get; set; }

        /// <summary>
        /// Rut de quien firma el recibo
        /// </summary>
        public string RutFirma { get; set; }
    }
}