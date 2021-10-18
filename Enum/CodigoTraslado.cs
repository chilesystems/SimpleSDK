using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class CodigoTraslado
    {
        /// <summary>
        /// Sólo para guías de despacho
        /// Tipos de código de traslado excepcional.
        /// </summary>
        public enum CodigoTrasladoEnum : int
        {
            /// <summary>
            /// No se ha asignado un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Exportador
            /// </summary>
            [XmlEnum("1")]
            Exportador = 1,
            /// <summary>
            /// Agente de Aduana (En la devolución de mercaderías de Aduanas).
            /// </summary>
            [XmlEnum("2")]
            AgenteAduana = 2,
            /// <summary>
            /// Vendedor (Entre otros, se refiere a aquel Productor que vende mercadería con entrega en Zona Primaria). 
            /// </summary>
            [XmlEnum("3")]
            Vendedor = 3,
            /// <summary>
            /// Contribuyente autorizado expresamente por el SII
            /// </summary>
            [XmlEnum("4")]
            ContribuyenteAutorizado = 4
        }
    }
}
