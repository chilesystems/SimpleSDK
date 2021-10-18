using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class OperacionDetalle
    {
        public enum OperacionDetalleEnum : int
        {
            /// <summary>
            /// No se ha establecido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Agrega
            /// </summary>
            [XmlEnum("1")]
            Agrega = 1,
            /// <summary>
            /// Elimina
            /// </summary>
            [XmlEnum("2")]
            Elimina = 2
        }
    }
}