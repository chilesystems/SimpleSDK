using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoLCE
    {
        public enum TipoLCEEnum : int
        {
            /// <summary>
            /// No se ha establecido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Contable. Incluye: Diario, Mayor, Balance, Inventarios y Balance.
            /// </summary>
            [XmlEnum("1")]
            Contable = 1,
            /// <summary>
            /// Remuneraciones
            /// </summary>
            [XmlEnum("2")]
            Remuneraciones = 2,
            /// <summary>
            /// Honorarios
            /// </summary>
            [XmlEnum("3")]
            Honorarios = 3,
            /// <summary>
            /// Regustro de existencias
            /// </summary>
            [XmlEnum("4")]
            RegistroExistencia = 4,
            /// <summary>
            /// Activo Fijo
            /// </summary>
            [XmlEnum("5")]
            ActivoFijo = 5,
            /// <summary>
            /// Compra y Venta
            /// </summary>
            [XmlEnum("6")]
            CompraVenta = 6
        }
    }
}