using System.Xml.Serialization;

namespace SimpleSDK.Models.RCOF
{
    public class RangoAnulados
    {
        [XmlElement("Inicial")]
        public int Inicial { get; set; }
        public bool ShouldSerializeInicial() { return Inicial != 0; }

        [XmlElement("Final")]
        public int Final { get; set; }
        public bool ShouldSerializeFinal() { return Final != 0; }

    }
}
