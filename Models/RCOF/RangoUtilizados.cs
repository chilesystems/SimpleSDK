using System.Xml.Serialization;

namespace SimpleSDK.Models.RCOF
{
    public class RangoUtilizados
    {
        [XmlElement("Inicial")]
        public long Inicial { get; set; }
        public bool ShouldSerializeInicial() { return Inicial != 0; }

        [XmlElement("Final")]
        public long Final { get; set; }
        public bool ShouldSerializeFinal() { return Final != 0; }
    }
}
