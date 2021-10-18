using System.Xml.Serialization;

namespace SimpleSDK.Enum
{
    public class ClaseCAL
    {
        public enum ClaseCALEnum : int
        {
            /// <summary>
            /// No se ha establecido un valor aún.
            /// </summary>
            [XmlEnum("")]
            NotSet = 0,
            /// <summary>
            /// Contribuyente. Sólo para su propio uso. Este CAL no se puede endosar
            /// </summary>
            [XmlEnum("1")]
            Contribuyente = 1,
            /// <summary>
            ///  Para uso de quien lo obtuvo y para empresas del holding. Este CAL es endosable.
            /// </summary>
            [XmlEnum("2")]
            Holding = 2,
            /// <summary>
            ///  Este CAL es endosable y vence anualmente. 
            /// </summary>
            [XmlEnum("3")]
            EmpresaSoftware = 3,
            /// <summary>
            /// Prestador de servicios contables.
            /// ??
            /// </summary>
            [XmlEnum("4")]
            PrestadorServicioContable = 4
        }
    }
}