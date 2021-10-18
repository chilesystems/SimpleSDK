using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoTraslado
    {
        /// <summary>
        /// Sólo para Guías de despacho.
        /// Indica si el traslado de mercadería es por Venta (valor 1) o por otros motivos que no corresponden a venta. (valores mayores a 1).
        /// 7: Para de devolución de mercaderías que fueron trasladadas para exportación desde la zona de embarque.
        /// 8 y 9: Para exportaciones, cuando se dirige la mercadería hacia el puerto, aeropuerto o aduana de embarque. 
        /// 9 : Entre otros, venta de mercaderías que se entregan en Zona Primaria de Aduanas para su exportación
        /// </summary>
        public enum TipoTrasladoEnum : int
        {
            /// <summary>
            /// No se ha asignado un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Operación constituye venta, de acuerdo a la definición de "venta" establecida en el Artículo 2° del DL 825.
            /// </summary>
            [XmlEnum("1")]
            OperacionConstituyeVenta = 1,
            [XmlEnum("2")]
            VentaPorEfectuar = 2,
            [XmlEnum("3")]
            Consignaciones = 3,
            [XmlEnum("4")]
            EntregaGratuita = 4,
            [XmlEnum("5")]
            TrasladosInternos = 5,
            [XmlEnum("6")]
            OtrosTrasladosNoVenta = 6,
            [XmlEnum("7")]
            GuiaDeDevolucion = 7,
            /// <summary>
            /// Traslado para exportación. (No venta).
            /// </summary>
            [XmlEnum("8")]
            TrasladoParaExportacion = 8,
            [XmlEnum("9")]
            VentaParaExportacion = 9
        }
    }
}
