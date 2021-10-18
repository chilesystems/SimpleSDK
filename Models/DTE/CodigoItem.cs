using SimpleSDK.Helpers;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class CodigoItem
    {
        [XmlIgnore]
        private string _tipoCodigo;
        /// <summary>
        /// Tipo de codificación utilizada para el item.
        /// Standart: EAN, PLU, DUN14, INT1, INT2, EAN128, Interna, etc.
        /// </summary>
        [XmlElement("TpoCodigo")]
        public string TipoCodigo { get { return _tipoCodigo.Truncate(10); } set { _tipoCodigo = value; } }

        [XmlIgnore]
        private string _valorCodigo;
        /// <summary>
        /// Valor del código para TipoCodigo.
        /// </summary>
        [XmlElement("VlrCodigo")]
        public string ValorCodigo { get { return _valorCodigo.Truncate(35); } set { _valorCodigo = value; } }

        public CodigoItem()
        {

        }
    }
}
