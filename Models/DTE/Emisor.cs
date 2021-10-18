using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using SimpleSDK.Helpers;

namespace SimpleSDK.Models.DTE
{
    public class Emisor
    {
        /// <summary>
        /// Rut del emisor del DTE
        /// Con guión y dígito verificador.
        /// Cuerpo numérico entre 100.000 y 99 millones, guión y dígito veridicador alfanumérico entre 0 y 9 o K.
        /// </summary>
        [XmlElement("RUTEmisor")]
        public string Rut { get; set; }

        /// <summary>
        /// Nombre o razón social del Emisor
        /// </summary>
        [XmlElement("RznSoc")]
        public string RazonSocial { get { return _razonSocial.Truncate(70); } set { _razonSocial = value; } }
        public bool ShouldSerializeRazonSocial() { return !String.IsNullOrEmpty(RazonSocial); }

        private string _razonSocial;

        [XmlElement("RznSocEmisor")]
        public string RazonSocialBoleta { get { return _razonSocialBoleta.Truncate(100); } set { _razonSocialBoleta = value; } }
        public bool ShouldSerializeRazonSocialBoleta() { return !String.IsNullOrEmpty(RazonSocialBoleta); }
        private string _razonSocialBoleta;

        [XmlIgnore]
        private string _giro;
        [XmlIgnore]
        private string _giroEmisor;
        /// <summary>
        /// Glosa indicando giro del emisor. No es preciso registrar todos los giros, sino que se podrá registrar sólo el giro que corresponde a la transacción.
        /// </summary>
        [XmlElement("GiroEmis")]
        public string Giro { get { return _giro.Truncate(80); } set { _giro = value; } }
        public bool ShouldSerializeGiro() { return !String.IsNullOrEmpty(_giro); }

        [XmlElement("GiroEmisor")]
        public string GiroBoleta { get { return _giroEmisor.Truncate(80); } set { _giroEmisor = value; } }
        public bool ShouldSerializeGiroBoleta() { return !String.IsNullOrEmpty(_giroEmisor); }

        [XmlIgnore]
        private List<string> _telefono;
        /// <summary>
        /// Primer teléfono del emisor
        /// </summary>
        [XmlElement("Telefono")]
        public List<string> Telefono { get { return _telefono; } set { _telefono = value; _telefono.ForEach(x => x.Truncate(20)); } }
        public bool ShouldSerializeTelefono() { return Telefono == null ? false : Telefono.Count() == 0 ? false : true; }

        /// <summary>
        /// Correo electrónico de contacto en empresa del receptor.
        /// </summary>
        [XmlElement("CorreoEmisor")]
        public string CorreoElectronico { get; set; }
        public bool ShouldSerializeCorreoElectronico() { return !String.IsNullOrEmpty(CorreoElectronico); }

        /// <summary>
        /// Código de actividad económica del emisor.
        /// Relevante para el DTE.
        /// Se acepta un máximo de 4 Códigos de actividad económica del emisor del DTE. 
        /// Se puede incluir sólo el código que corresponde a la transacción.  
        /// Número debe estar registrado en el SII
        /// </summary>
        [XmlElement("Acteco")]
        public List<int> ActividadEconomica { get; set; }

        /// <summary>
        /// Emisor de una Guía de despacho para exportación.
        /// </summary>
        [XmlElement("GuiaExport")]
        public GuiaExportacion GuiaExportacion { get; set; }
        public bool ShouldSerializeGuiaExportacion() { return GuiaExportacion != null; }

        [XmlIgnore]
        private string _sucursal;
        /// <summary>
        /// Sucursal que emite el DTE.
        /// Indica nombre de la sucursal que emite el Documento. Corresponde a un dato administrado por el emisor que puede ser un texto o un número
        /// </summary>
        [XmlElement("Sucursal")]
        public string Sucursal { get { return _sucursal.Truncate(20); } set { _sucursal = value; } }
        public bool ShouldSerializeSucursal() { return !String.IsNullOrEmpty(Sucursal); }

        /// <summary>
        /// Código numérico entregado por el SII, que identifica a cada sucursal que está identificada en el Servicio de Impuestos Internos.
        /// Si no hay sucursales se puede omitir.
        /// Deber corresponder a un código registrado en el SII
        /// </summary>
        [XmlElement("CdgSIISucur")]
        public int CodigoSucursal { get; set; }
        public bool ShouldSerializeCodigoSucursal() { return CodigoSucursal != 0; }

        [XmlIgnore]
        private string _dirOrigen;
        /// <summary>
        /// Datos correspondientes a Dirección desde donde se despachan bienes o de la sucursal que emite el documento si no hay despacho de bienes. 
        /// </summary>
        [XmlElement("DirOrigen")]
        public string DireccionOrigen { get { return _dirOrigen.Truncate(70); } set { _dirOrigen = value; } }
        public bool ShouldSerializeDireccionOrigen() { return !String.IsNullOrEmpty(DireccionOrigen); }

        /// <summary>
        /// Comuna de origen
        /// Análogo a dirección de origen
        /// </summary>
        [XmlElement("CmnaOrigen")]
        public string ComunaOrigen { get; set; }
        public bool ShouldSerializeComunaOrigen() { return !String.IsNullOrEmpty(ComunaOrigen); }

        /// <summary>
        /// Ciudad de origen
        /// Análogo a dirección de origen.
        /// </summary>
        [XmlElement("CiudadOrigen")]
        public string CiudadOrigen { get; set; }
        public bool ShouldSerializeCiudadOrigen() { return !String.IsNullOrEmpty(CiudadOrigen); }

        [XmlIgnore]
        private string _codigoVendedor;
        /// <summary>
        /// Código del vendedor.
        /// Glosa con identificador del vendedor.
        /// </summary>
        [XmlElement("CdgVendedor")]
        public string CodigoVendedor { get { return _codigoVendedor.Truncate(60); } set { _codigoVendedor = value; } }
        public bool ShouldSerializeCodigoVendedor() { return !String.IsNullOrEmpty(CodigoVendedor); }

        [XmlIgnore]
        private string _idAdicionalEmisor;
        /// <summary>
        /// Identificador Adicional del Emisor
        /// para documento utilizados en exportaciones.
        /// Codigo de identificación adicional para uso libre.
        /// </summary>
        [XmlElement("IdAdicEmisor")]
        public string IdentificadorAdicional { get { return _idAdicionalEmisor.Truncate(20); } set { _idAdicionalEmisor = value; } }
        public bool ShouldSerializeIdentificadorAdicional() { return !String.IsNullOrEmpty(IdentificadorAdicional); }

        public Emisor()
        {
            Rut = string.Empty;
            RazonSocial = string.Empty;
            Giro = string.Empty;
            ActividadEconomica = new List<int>();
            Telefono = new List<string>();
            CorreoElectronico = string.Empty;
            GuiaExportacion = null;
            Sucursal = string.Empty;
            CodigoSucursal = 0;
            DireccionOrigen = string.Empty;
            ComunaOrigen = string.Empty;
            CiudadOrigen = string.Empty;
            CodigoVendedor = string.Empty;
            IdentificadorAdicional = string.Empty;
        }
    }
}
