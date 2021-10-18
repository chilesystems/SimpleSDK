using System;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class GuiaExportacion
    {
        /// <summary>
        /// Sólo para Guía de Despacho:
        /// 1: Exportador
        /// 2: Agente de Aduana (En la devolución de mercaderías de Aduanas.
        /// 3: Vendedor (Entre otros, se refiere a aquel Productor que vende mercadería con entrega en Zona Primaria).
        /// 4: Contribuyente autorizado expresamente por el SII.
        /// 
        /// Obligatorio si "Documento.Encabezado.IdentifadorDTE.Indicador tipo traslado" con valor 8 y 9.
        /// </summary>
        [XmlElement("CdgTraslado")]
        public Enum.CodigoTraslado.CodigoTrasladoEnum CodigoEmisorTrasladoExcepcional { get; set; }
        public bool ShouldSerializeCodigoEmisorTrasladoExcepcional() { return CodigoEmisorTrasladoExcepcional != Enum.CodigoTraslado.CodigoTrasladoEnum.NotSet; }

        /// <summary>
        /// Sólo para Guía de Despacho: 
        /// Corresponde al N° de Resolución del SII donde en casos especiales se autoriza al contribuyente a emitir guías de despacho. 
        /// Campo obligatorio cuando se indique 4 (ContribuyenteAutorizado) en el Código de emisor de traslado excepcional
        /// </summary>
        [XmlElement("FolioAut")]
        public int FolioAutorizacion { get; set; }
        public bool ShouldSerializeFolioAutorizacion() { return FolioAutorizacion != 0; }

        /// <summary>
        /// Sólo para Guía de Despacho: 
        /// Fecha de emisión de la Resolución de autorización (AAAA-MM-DD)
        /// Campo obligatorio cuando se indique 4 (ContribuyenteAutorizado) en el Código Emisor Traslado Excepcional.
        /// Do not set this property, set FechaAutorizacion instead.
        /// </summary>
        [XmlElement("FchAut")]
        public string FechaAutorizacionString { get; set; }
        public bool ShouldSerializeFechaAutorizacionString() { return FechaAutorizacion != DateTime.MinValue; }

        /// <summary>
        /// Sólo para Guía de Despacho: 
        /// Fecha de emisión de la Resolución de autorización (AAAA-MM-DD)
        /// Campo obligatorio cuando se indique 4 (ContribuyenteAutorizado) en el Código Emisor Traslado Excepcional.
        /// </summary>
        [XmlIgnore]
        public DateTime FechaAutorizacion { get { return DateTime.Parse(FechaAutorizacionString); } set { this.FechaAutorizacionString = value.ToString("yyyy-MM-dd"); } }

        public GuiaExportacion()
        {
            CodigoEmisorTrasladoExcepcional = Enum.CodigoTraslado.CodigoTrasladoEnum.NotSet;
            FolioAutorizacion = 0;
            FechaAutorizacion = DateTime.MinValue;
        }
    }
}
