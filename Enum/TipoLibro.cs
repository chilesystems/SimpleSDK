using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoLibro
    {
        public enum TipoLibroEnum : int
        {
            /// <summary>
            /// Aún no se ha establecido un valor.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Libros regulares
            /// </summary>
            [XmlEnum("MENSUAL")]
            Mensual = 1,
            /// <summary>
            /// Libro solicitado vía una notificación.
            /// </summary>
            [XmlEnum("ESPECIAL")]
            Especial = 2,
            /// <summary>
            /// Libro que reemplaza a otro ya enviado al SII.
            /// </summary>
            [XmlEnum("RECTIFICA")]
            Rectifica = 3
        }

        public enum TipoLibroOrigen : int
        {
            /// <summary>
            /// Aún no se ha establecido un valor.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Libros regulares
            /// </summary>
            [XmlEnum("IECV")]
            IECV = 1,
            /// <summary>
            /// Libro solicitado vía una notificación.
            /// </summary>
            [XmlEnum("BOLETAS")]
            Boletas = 2,
            /// <summary>
            /// Libro que reemplaza a otro ya enviado al SII.
            /// </summary>
            [XmlEnum("GUIAS")]
            Guias = 3
        }
    }
}