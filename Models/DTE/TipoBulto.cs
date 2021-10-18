using SimpleSDK.Helpers;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class TipoBulto
    {
        /// <summary>
        /// Código según tabla "Tipos de bultos" de Aduana.
        /// </summary>
        [XmlElement("CodTpoBultos")]
        public Enum.CodigosAduana.TipoBultoEnum CodigoTipoBulto { get; set; }
        public bool ShouldSerializeCodigoTipoBulto() { return CodigoTipoBulto != Enum.CodigosAduana.TipoBultoEnum.NotSet; }
        /// <summary>
        /// Cantidad de Bultos
        /// </summary>
        [XmlElement("CantBultos")]
        public int CantidadBultos { get; set; }
        public bool ShouldSerializeCantidadBultos() { return CantidadBultos != 0; }

        [XmlIgnore]
        private string _marcas;
        /// <summary>
        /// Identificación de marcas, cuando es distinto de contenedor.
        /// </summary>
        [XmlElement("Marcas")]
        public string Marcas { get { return _marcas.Truncate(255); } set { _marcas = value; } }
        public bool ShouldSerializeMarcas() { return !string.IsNullOrEmpty(Marcas); }

        [XmlIgnore]
        private string _idContainer;
        /// <summary>
        /// Se utiliza cuando el tipo de bulto es contenedor.
        /// </summary>
        [XmlElement("IdContainer")]
        public string IdContainer { get { return _idContainer.Truncate(25); } set { _idContainer = value; } }
        public bool ShouldSerializeIdContainer() { return !string.IsNullOrEmpty(IdContainer); }

        [XmlIgnore]
        private string _sello;
        /// <summary>
        /// Sello contenedor, con dígito verificador.
        /// </summary>
        [XmlElement("Sello")]
        public string Sello { get { return _sello.Truncate(20); } set { _sello = value; } }
        public bool ShouldSerializeSello() { return !string.IsNullOrEmpty(Sello); }

        [XmlIgnore]
        private string _emisorSello;
        /// <summary>
        /// Nombre emisor sello.
        /// </summary>
        [XmlElement("EmisorSello")]
        public string EmisorSello { get { return _emisorSello.Truncate(70); } set { _emisorSello = value; } }
        public bool ShouldSerializeEmisorSello() { return !string.IsNullOrEmpty(EmisorSello); }

        public TipoBulto()
        {
            CodigoTipoBulto = 0;
            CantidadBultos = 0;
            Marcas = string.Empty;
            IdContainer = string.Empty;
            Sello = string.Empty;
            EmisorSello = string.Empty;
        }
    }
}
