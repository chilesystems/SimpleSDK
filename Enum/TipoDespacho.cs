using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoDespacho
    {
        /// <summary>
        /// Indica si el documento acompaña bienes y el despacho es por cuenta del vendedor o del comprador. No se incluye si el documento no acompaña bienes o se trata de una Factura o Nota correspondiente a la prestación de servicios.
        /// </summary>
        public enum TipoDespachoEnum : int
        {
            /// <summary>
            /// No se ha asignado un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Despacho por cuenta del receptor del documento (cliente o vendedor en caso de Facturas de compra.)
            /// </summary>
            [XmlEnum("1")]
            Receptor = 1,
            /// <summary>
            /// Despacho por cuenta del emisor a instalaciones del cliente
            /// </summary>
            [XmlEnum("2")]
            EmisorACliente = 2,
            /// <summary>
            /// Despacho por cuenta del emisor a otras instalaciones (Ejemplo: entrega en Obra)
            /// </summary>
            [XmlEnum("3")]
            EmisorAOtrasInstalaciones = 3
        }
    }
}
