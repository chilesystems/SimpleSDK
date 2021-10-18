using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class CodigoIVANoRecuperable
    {
        public enum CodigoIVANoRecuperableEnum : int
        {
            /// <summary>
            /// No se ha establecido un valor aún
            /// </summary>
            [XmlEnum("")]
            NotSet,
            /// <summary>
            /// Compras destinadas a generar operaciones no gravadas o exentas.
            /// </summary>
            [XmlEnum("1")]
            ComprasDestinadasAGenerarOperacioneExentas = 1,
            /// <summary>
            /// Facturas registradas fuera de plazo
            /// </summary>
            [XmlEnum("2")]
            FacturasRegistradasFueraPlazo = 2,
            /// <summary>
            /// Gastos rechazados
            /// </summary>
            [XmlEnum("3")]
            GastosRechazados = 3,
            /// <summary>
            /// Enrega gratuita
            /// </summary>
            [XmlEnum("4")]
            EntregaGratuita = 4,
            /// <summary>
            /// Otros.
            /// </summary>
            [XmlEnum("9")]
            Otros = 9
        }
    }
}
