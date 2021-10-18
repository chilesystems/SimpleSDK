using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class IndicadorServicio
    {
        /// <summary>
        /// Indica si la transacción corresponde a la prestación de un servicio
        /// </summary>
        public enum IndicadorServicioEnum : int
        {
            /// <summary>
            /// No se ha asignado un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Factura de servicios periódicos domiciliarios.
            /// Los servicios periódictos domiciliarios son aquellos identificados en DL 825, art. 9° en que el impuesto se devenga en la fecha de vencimiento. 
            /// </summary>
            //[XmlEnum("01")]
            //FacturaServiciosPeriodicosDomiciliarios=1,
            [XmlEnum("1")]
            FacturaServiciosPeriodicosDomiciliarios2 = 1,
            /// <summary>
            /// Factua de otros servicios periódicos
            /// </summary>
            //[XmlEnum("02")]
            //FacturaOtrosServiciosPeriódicos=2,
            [XmlEnum("2")]
            FacturaOtrosServiciosPeriódicos2 = 2,
            /// <summary>
            /// Factura de servicios.
            /// En caso de factura de exportación: Servicios calificados como tal por Aduana.
            /// </summary>
            //[XmlEnum("03")]
            //FacturaServicios=3,
            [XmlEnum("3")]
            FacturaServicios2 = 3,
            /// <summary>
            /// Servios de Hotelería
            /// </summary>
            //[XmlEnum("04")]
            //ServiciosHoteleria=4,
            [XmlEnum("4")]
            ServiciosHoteleria2 = 4,
            /// <summary>
            /// Servicios de transporte terrestre internacional.
            /// </summary>
            //[XmlEnum("05")]
            //ServicioTransporteTerrestreInternacional = 5,
            [XmlEnum("5")]
            ServicioTransporteTerrestreInternacional2 = 5,

            [XmlEnum("1")]
            BoletaServiciosPeriodicos = 1,
            [XmlEnum("2")]
            BoletaServiciosPeriodicosDomiciliarios = 2,
            [XmlEnum("3")]
            BoletaVentasYServicios = 3,
            [XmlEnum("4")]
            BoletaEspectaculosPorTerceros = 4
        }

        //public enum IndicadorServicioBoletaEnum : int
        //{
        //    [XmlEnum("")]
        //    NotSet = 0,
        //    [XmlEnum("1")]
        //    BoletaServiciosPeriodicos = 1,
        //    [XmlEnum("2")]
        //    BoletaServiciosPeriodicosDomiciliarios = 2,
        //    [XmlEnum("3")]
        //    BoletaVentasYServicios = 3,
        //    [XmlEnum("4")]
        //    BoletaEspectaculosPorTerceros = 4
        //}

        /// <summary>
        /// Indica si la transacción corresponde a la prestación de un servicio
        /// </summary>
        public enum IndicadorServicioDetalleLibroEnum : int
        {
            /// <summary>
            /// No se ha asignado un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Factura de servicios periódicos domiciliarios.
            /// Los servicios periódictos domiciliarios son aquellos identificados en DL 825, art. 9° en que el impuesto se devenga en la fecha de vencimiento. 
            /// </summary>
            [XmlEnum("1")]
            FacturaServiciosPeriodicosDomiciliarios = 1,
            /// <summary>
            /// Factua de otros servicios periódicos
            /// </summary>
            [XmlEnum("2")]
            FacturaOtrosServiciosPeriódicos = 2,
            /// <summary>
            /// Factura de servicios.
            /// En caso de factura de exportación: Servicios calificados como tal por Aduana.
            /// </summary>
            [XmlEnum("3")]
            FacturaServicios = 3
        }
    }
}
