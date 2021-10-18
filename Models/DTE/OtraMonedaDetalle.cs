using System;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class OtraMonedaDetalle
    {
        [XmlIgnore]
        private double _precioUnitario;
        /// <summary>
        /// Precio unitario en otra moneda.
        /// Obligatorio en Guías de Despacho con Indicador de tipo de Traslado de Bienes = 9.
        /// </summary>
        [XmlElement("PrcOtrMon")]
        public double PrecioUnitario { get { return Math.Round(_precioUnitario, 4); } set { _precioUnitario = value; } }

        /// <summary>
        /// Código de otra moneda.
        /// (Usar códigos de otra moneda del banco central).
        /// </summary>
        [XmlElement("Moneda")]
        public Enum.TipoMonedaBancoCentral.TipoMonedaBancoCentralEnum Moneda { get; set; }

        [XmlIgnore]
        private double _factorConversion;
        /// <summary>
        /// Factor para conversión a pesos.
        /// En documentos de Exportación corresponde al tipo de cambio de la fecha de emisión del documento, publicado por el Banco Central de Chile. 
        /// </summary>
        [XmlElement("FctConv")]
        public double FactorConversion { get { return Math.Round(_factorConversion, 4); } set { _factorConversion = value; } }
        public bool ShouldSerializeFactorConversion() { return FactorConversion != 0; }

        [XmlIgnore]
        private double _descuento;
        /// <summary>
        /// Descuento en otra moneda.
        /// Dinero correspondiente al Descuento en %. Totaliza todos los descuentos otorgados al ítem en otra moneda.
        /// </summary>
        [XmlElement("DctoOtrMnda")]
        public double Descuento { get { return Math.Round(_descuento, 4); } set { _descuento = value; } }
        public bool ShouldSerializeDescuento() { return Descuento != 0; }

        [XmlIgnore]
        private double _recargo;
        /// <summary>
        /// Recargo en otra moneda.
        /// Dinero correspondiente al Recargo en %. Totaliza todos los recargos otorgados al ítem en otra moneda.
        /// </summary>
        [XmlElement("RecargoOtrMnda")]
        public double Recargo { get { return Math.Round(_recargo, 4); } set { _recargo = value; } }
        public bool ShouldSerializeRecargo() { return Recargo != 0; }

        [XmlIgnore]
        private double _valor;
        /// <summary>
        /// Valor por línea de detalle en otra moneda.
        /// (Precio Unitario en otra moneda * Cantidad ) – Descuento en otra moneda + Recargo en otra moneda.
        /// Obligatorio en Guías de Despacho con Indicador de tipo de Traslado de Bienes = 9.
        /// </summary>
        [XmlElement("MontoItemOtrMnda")]
        public double Valor { get { return Math.Round(_valor, 4); } set { _valor = value; } }
        public bool ShouldSerializeValor() { return Valor != 0; }

        public OtraMonedaDetalle()
        {
            PrecioUnitario = 0;
            Moneda = Enum.TipoMonedaBancoCentral.TipoMonedaBancoCentralEnum.NotSet;
            FactorConversion = 0;
            Descuento = 0;
            Recargo = 0;
            Valor = 0;
        }
    }
}
