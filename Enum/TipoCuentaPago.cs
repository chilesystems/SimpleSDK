using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoCuentaPago
    {
        public enum TipoCuentaPagoEnum
        {
            /// <summary>
            /// No se ha definido un valor aún
            /// </summary>
            [XmlEnum("")]
            NotSet,
            /// <summary>
            /// Cuenta Corriente
            /// </summary>
            [XmlEnum("CORRIENTE")]
            CuentaCorriente,
            /// <summary>
            /// Cuenta Ahorro
            /// </summary>
            [XmlEnum("AHORRO")]
            Ahorro,
            /// <summary>
            /// Cuenta Ahorro
            /// </summary>
            [XmlEnum("VISTA")]
            Vista,
            /// <summary>
            /// OTRO
            /// </summary>
            [XmlEnum("")]
            Otro
        }
    }
}
