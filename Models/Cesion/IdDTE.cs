using System;

namespace SimpleSDK.Models.Cesion
{
    public class IdDTE
    {
        /// <summary>
        /// Tipo de DTE
        /// </summary>
        public Enum.TipoDTE.DTEType TipoDTE { get; set; }
        public string RUTEmisor { get; set; }
        public string RUTReceptor { get; set; }

        public long Folio { get; set; }

        /// <summary>
        /// Fecha Emisión Contable del DTE.
        /// </summary>
        public DateTime FechaEmision { get; set; }

        public int MontoTotal { get; set; }

        public IdDTE()
        {
        }
    }
}
