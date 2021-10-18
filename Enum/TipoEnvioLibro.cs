using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoEnvioLibro
    {
        public enum TipoEnvioLibroEnum : int
        {
            /// <summary>
            /// Aún no se ha establecido un valor.
            /// </summary>
            [XmlEnum("")]
            NotSet,
            /// <summary>
            /// Información total del mes.
            /// </summary>
            [XmlEnum("TOTAL")]
            Total = 1,
            /// <summary>
            /// Se está enviando un segmento que tiene parte de la información del periodo.
            /// </summary>
            [XmlEnum("PARCIAL")]
            Parcial = 2,
            /// <summary>
            /// Corresponde al último segmento.
            /// </summary>
            [XmlEnum("FINAL")]
            Final = 3,
            /// <summary>
            /// Movimientos ingresados con posterioridad a un envío FINAL o TOTAL.
            /// </summary>
            [XmlEnum("AJUSTE")]
            Ajuste = 4
        }
    }
}