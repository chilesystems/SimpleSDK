using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.RCOF
{
    [XmlRoot("Documento")]
    public class DocumentoConsumoFolios
    {
        [XmlAttribute("ID")]
        public string Id { get; set; }

        [XmlElement("Caratula")]
        public Caratula Caratula { get; set; }

        [XmlIgnore]
        private List<Resumen> _resumen { get; set; }

        [XmlElement("Resumen")]
        public List<Resumen> Resumen
        {
            //get
            //{
            //    return _resumen.Where(x => x.MntTotal != 0).ToList();
            //}
            get { return _resumen; }
            set { _resumen = value; }
        }

        public DocumentoConsumoFolios()
        {
            Caratula = new Caratula();
            _resumen = new List<RCOF.Resumen>();
        }
    }
}
