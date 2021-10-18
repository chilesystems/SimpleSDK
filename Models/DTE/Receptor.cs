using System;
using System.Xml.Serialization;
using SimpleSDK.Helpers;

namespace SimpleSDK.Models.DTE
{
    public class Receptor
    {
        /// <summary>
        /// Rut del receptor del DTE.
        /// Corresponde al RUT del cliente, excepto en la Factura de compra en que se referencia al vendedor.
        /// Con guión y dígito verificador
        /// </summary>
        [XmlElement("RUTRecep")]
        public string Rut { get; set; }

        [XmlIgnore]
        private string _codigoInterno;
        /// <summary>
        /// Código interno del receptor.
        /// Para identificación interna del Receptor, por ejemplo código del cliente, número de medidor, etc.
        /// </summary>
        [XmlElement("CdgIntRecep")]
        public string CodigoInterno { get { return _codigoInterno.Truncate(20); } set { _codigoInterno = value; } }
        public bool ShouldSerializeCodigoInterno() { return !String.IsNullOrEmpty(CodigoInterno); }

        /// <summary>
        /// Nombre o razón social del receptor.
        /// </summary>
        [XmlElement("RznSocRecep")]
        public string RazonSocial { get; set; }

        /// <summary>
        /// Receptor extranjero.
        /// </summary>
        [XmlElement("Extranjero")]
        public Extranjero Extranjero { get; set; }
        public bool ShouldSerializeExtranjero() { return Extranjero != null; }

        [XmlIgnore]
        private string _giro;
        /// <summary>
        /// Giro comercial del receptor.
        /// Glosa impresa indicando giro del receptor.
        /// </summary>
        [XmlElement("GiroRecep")]
        public string Giro { get { return _giro.Truncate(40); } set { _giro = value; } }
        public bool ShouldSerializeGiro() { return !String.IsNullOrEmpty(Giro); }

        [XmlIgnore]
        private string _contacto;
        /// <summary>
        /// Teléfono e Email del contacto del receptor.
        /// Glosa con nombre y teléfono de contacto en empresa del receptor (para registrar el “Atención A:” ).
        /// </summary>
        [XmlElement("Contacto")]
        public string Contacto { get { return _contacto.Truncate(80); } set { _contacto = value; } }
        public bool ShouldSerializeContacto() { return !String.IsNullOrEmpty(Contacto); }

        /// <summary>
        /// Correo electrónico de contacto en empresa del receptor.
        /// E-mail de contacto en empresa del receptor (para registrar el “Atención A:” ).
        /// </summary>
        [XmlElement("CorreoRecep")]
        public string CorreoElectronico { get; set; }
        public bool ShouldSerializeCorreoElectronico() { return !String.IsNullOrEmpty(CorreoElectronico); }

        [XmlIgnore]
        private string _direccion;
        /// <summary>
        /// Dirección en la cual se envían los productos o se prestan los servicios.
        /// Dirección Legal del Receptor (registrada en el SII).
        /// En caso de documentos de exportación, corresponde a la dirección en el extranjero del Receptor
        /// </summary>
        [XmlElement("DirRecep")]
        public string Direccion { get { return _direccion.Truncate(70); } set { _direccion = value; } }
        public bool ShouldSerializeDireccion() { return !String.IsNullOrEmpty(Direccion); }

        [XmlIgnore]
        private string _comuna;
        /// <summary>
        /// Comuna de recepción.
        /// Análogo a Dirección Receptor.
        /// </summary>
        [XmlElement("CmnaRecep")]
        public string Comuna { get { return _comuna.Truncate(20); } set { _comuna = value; } }
        public bool ShouldSerializeComuna() { return !String.IsNullOrEmpty(Comuna); }

        /// <summary>
        /// Ciudad de recepción.
        /// Análogo a Dirección Receptor.
        /// </summary>
        [XmlElement("CiudadRecep")]
        public string Ciudad { get; set; }
        public bool ShouldSerializeCiudad() { return !String.IsNullOrEmpty(Ciudad); }

        [XmlIgnore]
        private string _dirPostal;
        /// <summary>
        /// Dirección postal.
        /// Análogo a Dirección Receptor.
        /// </summary>
        [XmlElement("DirPostal")]
        public string DireccionPostal { get { return _dirPostal.Truncate(70); } set { _dirPostal = value; } }
        public bool ShouldSerializeDireccionPostal() { return !String.IsNullOrEmpty(DireccionPostal); }

        /// <summary>
        /// Comuna postal.
        /// Análogo a Dirección Receptor.
        /// </summary>
        [XmlElement("CmnaPostal")]
        public string ComunaPostal { get; set; }
        public bool ShouldSerializeComunaPostal() { return !String.IsNullOrEmpty(ComunaPostal); }

        /// <summary>
        /// Ciudad postal.
        /// Análogo a Dirección Receptor.
        /// </summary>
        [XmlElement("CiudadPostal")]
        public string CiudadPostal { get; set; }
        public bool ShouldSerializeCiudadPostal() { return !String.IsNullOrEmpty(CiudadPostal); }

        public Receptor()
        {
            Rut = string.Empty;
            RazonSocial = string.Empty;
            CodigoInterno = string.Empty;
            Extranjero = null;
            Giro = string.Empty;
            Contacto = string.Empty;
            CorreoElectronico = string.Empty;
            Direccion = string.Empty;
            Comuna = string.Empty;
            Ciudad = string.Empty;
            DireccionPostal = string.Empty;
            ComunaPostal = string.Empty;
            CiudadPostal = string.Empty;
        }
    }
}
