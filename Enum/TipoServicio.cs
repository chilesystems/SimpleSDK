using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class TipoServicio
    {
        public enum TipoServicioEnum : int
        {
            /// <summary>
            /// No se ha asignado un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            [XmlEnum("1")]
            BoletaServiciosPeriodicos = 1,
            [XmlEnum("2")]
            BoletaServiciosPeriodicosDomiciliarios = 2,
            [XmlEnum("3")]
            BoletaVentasYServicios = 3,
            [XmlEnum("4")]
            BoletaEspectaculosPorTerceros = 4
        }
    }
}
