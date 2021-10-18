using System;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class Encabezado
    {
        /// <summary>
        /// Identificación y totales del documento.
        /// </summary>
        [XmlElement("IdDoc")]
        public IdentificacionDTE IdentificacionDTE { get; set; }

        /// <summary>
        /// Datos del emisor
        /// </summary>
        [XmlElement("Emisor")]
        public Emisor Emisor { get; set; }

        /// <summary>
        /// Rut a cuenta de quien se emite el DTE.
        /// Corresponde al RUT del mandante si el total de la venta o servicio es por cuenta de otro el cual es responsable del IVA devengado en el período.
        /// Con guión y dígito verificador 
        /// </summary>
        [XmlElement("RUTMandante")]
        public string RutMandante { get; set; }
        public bool ShouldSerializeRutMandante() { return !String.IsNullOrEmpty(RutMandante); }

        /// <summary>
        /// Datos del receptor
        /// </summary>
        [XmlElement("Receptor")]
        public Receptor Receptor { get; set; }

        /// <summary>
        /// Rut que solicita el DTE en venta a público.
        /// En casos de venta a público. Es obligatorio si es distinto de Rut receptor o Rut Receptor es persona jurídica. 
        /// Con guión y dígito verificador 
        /// </summary>
        [XmlElement("RUTSolicita")]
        public string RutSolicitante { get; set; }
        public bool ShouldSerializeRutSolicitante() { return !String.IsNullOrEmpty(RutSolicitante); }

        /// <summary>
        /// Información de transporte de mercaderías.
        /// </summary>
        [XmlElement("Transporte")]
        public Transporte Transporte { get; set; }
        public bool ShouldSerializeTransporte() { return Transporte != null; }

        /// <summary>
        /// Montos totales del DTE
        /// </summary>
        [XmlElement("Totales")]
        public Totales Totales { get; set; }

        /// <summary>
        /// Otra moneda.
        /// </summary>
        [XmlElement("OtraMoneda")]
        public OtraMoneda OtraMoneda { get; set; }
        public bool ShouldSerializeOtraMoneda() { return OtraMoneda.TipoMoneda != Enum.CodigosAduana.Moneda.NotSet; }

        public Encabezado()
        {
            RutMandante = string.Empty;
            RutSolicitante = string.Empty;

            IdentificacionDTE = new IdentificacionDTE();
            Emisor = new Emisor();
            Receptor = new Receptor();
            Transporte = null;
            Totales = new Totales();
            OtraMoneda = new OtraMoneda();
        }
    }
}
