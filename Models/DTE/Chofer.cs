using System.Xml.Serialization;
using SimpleSDK.Helpers;

namespace SimpleSDK.Models.DTE
{
    public class Chofer
    {
        /// <summary>
        /// Rut del chofer.
        /// Rut Chofer que realiza el transporte de mercaderías. 
        /// Con guión y dígito verificador.
        /// </summary>
        [XmlElement("RUTChofer")]
        public string Rut { get; set; }

        [XmlIgnore]
        private string _nombre;
        /// <summary>
        /// Nombre del chofer.
        /// </summary>
        [XmlElement("NombreChofer")]
        public string Nombre { get { return _nombre.Truncate(30); } set { _nombre = value; } }

        public Chofer()
        {
            Rut = string.Empty;
            Nombre = string.Empty;
        }
    }
}
