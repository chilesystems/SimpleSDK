using SimpleSDK.Helpers;
using System;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class Referencia
    {
        /// <summary>
        /// Numero secuencial de la referencia.
        /// De 1 a 40.
        /// </summary>
        [XmlElement("NroLinRef")]
        public int Numero { get; set; }

        /// <summary>
        /// Indica el tipo de documento siendo referenciado.
        /// De acuerdo con la Descripción si se requiere referenciar un documento tributario se debe utilizar un valor Numérico que debe estar en el rango indicado en la descripción.
        /// Si es alfabético no hay validación y el contribuyente puede usarlo para referenciar documentos no tributarios y distintos de los especificados.
        /// En el caso de factura de exportación se puede indicar un DUS por factura.
        /// En el caso de exportaciones por vía terrestre y servicio de transporte internacional (“Indicador Servicio” =5), se puede indicar sólo una Carta de Porte por factura.
        /// En el caso de la Nota de Crédito y de Débito de Exp. es obligatorio referenciar la factura de exportación que modifica.
        /// Por cada Guía de Despacho se puede referenciar sólo 1 DUS o MIC.
        /// </summary>
        [XmlElement("TpoDocRef")]
        public string TipoDocumento { get; set; }
        public bool ShouldSerializeTipoDocumento() { return !string.IsNullOrEmpty(TipoDocumento); }

        /// <summary>
        /// Indicador de referencia global.
        /// Documento afecta a un número de más de 20 documentos del mismo Tipo de referencia.
        /// Se explicita la razón en Razón de referencia.
        /// Valor = 1. Ejemplo: Factura de todas las guías del mes.
        /// </summary>
        [XmlElement("IndGlobal")]
        public int IndicadorGlobal { get; set; }
        public bool ShouldSerializeIndicadorGlobal() { return IndicadorGlobal != 0; }

        /// <summary>
        /// Identificación del documento siendo referenciado.
        /// Debe ser cero sólo si el documento tiene el indicador de referencia global en 1.
        /// Puede ser alfanumérico si se trata de un documento no tributario (rango 800).
        /// </summary>
        [XmlElement("FolioRef")]
        public string FolioReferencia { get; set; }
        public bool ShouldSerializeFolioReferencia() { return !String.IsNullOrEmpty(FolioReferencia); }

        /// <summary>
        /// Sólo si el documento de referencia es de tipo tributario y fue emitido por otro contribuyente.
        /// Con guión y dígito verificador.
        /// Esto se aplica cuando: 
        ///  i) se emiten Facturas de Compra por bienes y se debe referenciar el número de la Guía de Despacho emitida por el Vendedor; 
        ///  ii) emitir Notas de Crédito o Débito que referencian DTE emitido por contribuyente fusionado o absorbido. 
        /// No se usa para referenciar una Orden de Compra porque éste no es un documento tributario.
        /// </summary>
        [XmlElement("RUTOtr")]
        public string RutReferencia { get; set; }
        public bool ShouldSerializeRutReferencia() { return !String.IsNullOrEmpty(RutReferencia); }

        /// <summary>
        /// Fecha del documento siendo referenciado.
        /// Do not set this property, set FechaDocumentoReferenciaInstead.
        /// </summary>
        [XmlElement("FchRef")]
        public string FechaDocumentoReferenciaString { get; set; }
        public bool ShouldSerializeFechaDocumentoReferenciaString() { return FechaDocumentoReferencia != DateTime.MinValue; }

        /// <summary>
        /// Fecha del documento siendo referenciado.
        /// </summary>
        [XmlIgnore]
        public DateTime FechaDocumentoReferencia { get { return DateTime.Parse(FechaDocumentoReferenciaString); } set { FechaDocumentoReferenciaString = value.ToString("yyyy-MM-dd"); } }

        /// <summary>
        /// Código utilizado para los siguientes casos:
        /// a) Nota de Crédito que elimina documento de referencia en forma completa (Factura de venta, Nota de débito, o Factura de compra.
        /// b) Nota de crédito que corrige un texto del documento de referencia (ver campo Corrección Factura).
        /// c) Nota de Débito que elimina una Nota de Crédito en la referencia en forma completa.
        /// d) Notas de crédito o débito que corrigen montos de otro documento CASOS a) b) y c). 
        /// DEBEN TENER UN ÚNICO DOCUMENTO DE REFERENCIA.
        /// </summary>
        [XmlElement("CodRef")]
        public Enum.TipoReferencia.TipoReferenciaEnum CodigoReferencia { get; set; }
        public bool ShouldSerializeCodigoReferencia() { return CodigoReferencia != Enum.TipoReferencia.TipoReferenciaEnum.NotSet; }
        //public bool ShouldSerializeCodigoReferencia() { return true; }

        [XmlIgnore]
        private string _razonReferencia;
        /// <summary>
        ///  Ejemplo: Una Nota de Crédito que hacer referencia a una factura, indica "descuento por pronto pago" o "error en precio" etc.
        /// </summary>
        [XmlElement("RazonRef")]
        public string RazonReferencia { get { return _razonReferencia.Truncate(90); } set { _razonReferencia = value; } }
        public bool ShouldSerializeRazonReferencia() { return !String.IsNullOrEmpty(RazonReferencia); }

        public Referencia()
        {
            Numero = 0;
            TipoDocumento = string.Empty;
            FolioReferencia = string.Empty;
            FechaDocumentoReferencia = DateTime.MinValue;

            IndicadorGlobal = 0;
            RutReferencia = string.Empty;
            CodigoReferencia = Enum.TipoReferencia.TipoReferenciaEnum.NotSet;
            RazonReferencia = string.Empty;
        }
    }
}
