using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoOperacionLibro
    {
        public enum TipoOperacionLibroEnum : int
        {
            /// <summary>
            /// Aún no se ha establecido un valor.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Para libros de venta.
            /// </summary>
            [XmlEnum("VENTA")]
            Venta = 1,
            /// <summary>
            /// Para libros de compra.
            /// </summary>
            [XmlEnum("COMPRA")]
            Compra = 2
        }
    }
}