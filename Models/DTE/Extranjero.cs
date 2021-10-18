using System;
using System.Xml.Serialization;
using SimpleSDK.Helpers;

namespace SimpleSDK.Models.DTE
{
    public class Extranjero
    {
        [XmlIgnore]
        private string _id;
        /// <summary>
        /// Número identificador del receptor extranjero.
        /// Corresponde al número o código de identificación personal del receptor extranjero, otorgado por la Administración tributaria extranjera u organismo Gubernamental competente.
        /// Se deben incluir guiones y dígitos verificadores.
        /// </summary>
        [XmlElement("NumId")]
        public string Id { get { return _id.Truncate(20); } set { _id = value; } }
        public bool ShouldSerializeId() { return !String.IsNullOrEmpty(Id); }

        [XmlElement]
        private string _nacionalidad;
        /// <summary>
        /// Nacionalidad del receptor extranjero.
        /// Corresponde a la nacionalidad del extranjero, según tabla de países de Aduana. 
        /// https://www.aduana.cl/compendio-de-normas-anexo-51/aduana/2008-02-18/165942.html Anexo 51-9.
        /// </summary>
        [XmlElement("Nacionalidad")]
        public SimpleSDK.Enum.CodigosAduana.Paises Nacionalidad { get; set; }
        public bool ShouldSerializeNacionalidad() { return Nacionalidad != SimpleSDK.Enum.CodigosAduana.Paises.NotSet; }

        public Extranjero()
        {
            Id = string.Empty;
            Nacionalidad = SimpleSDK.Enum.CodigosAduana.Paises.NotSet;
        }
    }
}
