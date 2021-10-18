using SimpleSDK.Helpers;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class SubCantidad
    {
        /// <summary>
        /// Cantidad distribuida.
        /// </summary>
        [XmlElement("SubQty")]
        public double Cantidad { get; set; }

        [XmlIgnore]
        public string _codigo;
        /// <summary>
        /// Codigo descriptivo de la subcantidad.
        /// </summary>
        [XmlElement("SubCod")]
        public string Codigo { get { return _codigo.Truncate(35); } set { _codigo = value; } }

        public SubCantidad()
        {
            Cantidad = 0;
            Codigo = string.Empty;
        }
    }
}
