using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.ReciboMercaderia
{
    /// <summary>
    /// Conjunto de Recibos Enviados
    /// </summary>
    public class SetRecibos
    {
        [XmlIgnore]
        public bool serializeRecibos { get; private set; }

        [XmlAttribute("ID")]
        public string Id { get; set; }

        /// <summary>
        /// Resumen de Informacion Enviada
        /// </summary>
        [XmlElement("Caratula")]
        public Caratula Caratula { get; set; }

        /// <summary>
        ///Comprobante de Recepcion de Mercaderias o Servicios Prestados Recibos de Recepcion de Mercaderias o Servicios Prestados
        /// </summary>
        [XmlElement("Recibo")]
        public List<Recibo> Recibos { get; set; }
        public bool ShouldSerializeRecibos() { return serializeRecibos; }

        [XmlIgnore]
        public List<string> signedXmls { get; set; }       

        public SetRecibos()
        {
            signedXmls = new List<string>();
            serializeRecibos = false;
        }
    }
}