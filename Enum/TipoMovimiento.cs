using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoMovimiento
    {
        public enum TipoMovimientoEnum
        {
            /// <summary>
            /// Aún no se ha definido un valor.
            /// </summary>
            [XmlEnum("")]
            NotSet,
            [XmlEnum("D")]
            Descuento,
            [XmlEnum("R")]
            Recargo
        }
    }
}
