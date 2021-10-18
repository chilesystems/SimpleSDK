using System.Xml.Serialization;
using SimpleSDK.Helpers;

namespace SimpleSDK.Models.DTE
{
    public class MontoPagoItem
    {
        /// <summary>
        /// Fecha de pago programado. AAAA-MM-DD
        /// </summary>
        [XmlElement("FchPago")]
        public string FechaPago { get; set; }

        /// <summary>
        /// Monto de pago programado.
        /// </summary>
        [XmlElement("MntPago")]
        public int MontoPago { get; set; }

        [XmlIgnore]
        private string _glosa;
        /// <summary>
        /// Glosa adicional para calificar pago
        /// </summary>
        [XmlElement("GlosaPagos")]
        public string GlosaDescripcion { get { return _glosa.Truncate(40); } set { _glosa = value; } }
    }
}
