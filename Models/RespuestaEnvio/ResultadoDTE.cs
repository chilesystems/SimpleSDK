using System;

namespace SimpleSDK.Models.RespuestaEnvio
{
    public class ResultadoDTE
    {
        /// <summary>
        /// Tipo de DTE.
        /// </summary>
        public Enum.TipoDTE.DTEType TipoDTE { get; set; }

        /// <summary>
        /// Folio del DTE.
        /// </summary>
        public long Folio { get; set; }

        /// <summary>
        /// Fecha emision contable del DTE.
        /// </summary>
        public DateTime FechaEmision { get; set; }

        /// <summary>
        /// RUT emisor del DTE.
        /// </summary>
        public string RutEmisor { get; set; }

        /// <summary>
        /// RUT receptor del DTE.
        /// </summary>
        public string RutReceptor { get; set; }

        /// <summary>
        /// Monto total del DTE.
        /// </summary>
        public int MontoTotal { get; set; }

        /// <summary>
        /// Codigo de identificación del envío en que se recibió el DTE.
        /// </summary>
        public int CodigoEnvio { get; set; }

        /// <summary>
        /// Estado de aprobación comercial del DTE.
        /// </summary>
        public Enum.EstadoResultadoDTE.EstadoResultadoDTEEnum EstadoDTE { get; set; }

        /// <summary>
        /// Información adicional para el estado de aprobación del DTE.
        /// </summary>
        public string GlosaEstadoDTE { get; set; }

        /// <summary>
        /// Código de motivo de rechazo o discrepancia.
        /// Código numérico de rechazo o discrepancia para ser codificado a futuro.
        /// </summary>
        public int CodigoRechazoODiscrepancia { get; set; }
    }
}
