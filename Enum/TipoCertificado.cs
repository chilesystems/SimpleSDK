using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoCertificado
    {
        public enum TipoCertificadoEnum : int
        {
            /// <summary>
            /// No se ha establecido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet,
            /// <summary>
            /// Certificación
            /// </summary>
            [XmlEnum("C")]
            Certificacion,
            /// <summary>
            /// Produccción.
            /// </summary>
            [XmlEnum("P")]
            Produccion
        }
    }
}