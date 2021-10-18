using System;

namespace SimpleSDK.Models.RespuestaEnvio
{
    public class RecepcionDTE
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
        /// Estado de recepción del DTE.
        public Enum.EstadoRecepcionDTE.EstadoRecepcionDTEEnum EstadoRecepcionDTE { get; set; }
        /// <summary>
        /// Información adicional para el estado de recepción del DTE.
        /// </summary>
        public string GlosaEstadoRecepcionDTE { get; set; }
    }
}
