using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class IndicadorSinCosto
    {
        public enum IndicadorSinCostoEnum : int
        {
            /// <summary>
            /// No se ha establecido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Entrega gratuita.
            /// </summary>
            [XmlEnum("1")]
            VentaSinCosto = 1
        }
    }
}