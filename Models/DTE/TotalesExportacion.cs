using SimpleSDK.Enum;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class TotalesExportacion
    {
        [XmlElement("TpoMoneda")]
        public CodigosAduana.Moneda TipoMoneda { get; set; }
        public bool ShouldSerializeTipoMoneda() { return TipoMoneda != CodigosAduana.Moneda.NotSet; }

        /// <summary>
        /// Monto exento del DTE.
        /// </summary>
        [XmlElement("MntExe")]
        public double MontoExento { get; set; }
        public bool ShouldSerializeMontoExento() { return MontoExento != 0; }

        /// <summary>
        /// Monto total del DTE.
        /// </summary>
        [XmlElement("MntTotal")]
        public double MontoTotal { get; set; }


        public TotalesExportacion()
        {
            TipoMoneda = CodigosAduana.Moneda.NotSet;
            MontoTotal = 0;
            MontoExento = 0;
        }
    }
}
