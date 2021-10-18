using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.RCOF
{
    public class Resumen
    {
        [XmlElement("TipoDocumento")]
        public Enum.TipoDTE.DTEType TipoDocumento { get; set; }

        [XmlElement("MntNeto")]
        public int MntNeto { get; set; }
        public bool ShouldSerializeMntNeto() { return MntNeto != 0; }

        [XmlElement("MntIva")]
        public int MntIva { get; set; }
        public bool ShouldSerializeMntIva() { return MntIva != 0; }

        [XmlElement("TasaIVA")]
        public double TasaIVA { get; set; }
        public bool ShouldSerializeTasaIVA() { return TasaIVA != 0; }

        [XmlElement("MntExento")]
        public int MntExento { get; set; }
        public bool ShouldSerializeMntExento() { return MntExento != 0; }

        [XmlElement("MntTotal")]
        public int MntTotal { get; set; }

        [XmlElement("FoliosEmitidos")]
        public int FoliosEmitidos { get; set; }

        [XmlElement("FoliosAnulados")]
        public int FoliosAnulados { get; set; }

        [XmlElement("FoliosUtilizados")]
        public int FoliosUtilizados { get; set; }

        [XmlElement("RangoUtilizados")]
        public List<RangoUtilizados> RangoUtilizados { get; set; }
        public bool ShouldSerializeRangoUtilizados() { return RangoUtilizados != null && RangoUtilizados.Count != 0; }

        [XmlElement("RangoAnulados")]
        public List<RangoAnulados> RangoAnulados { get; set; }
        public bool ShouldSerializeRangoAnulados() { return RangoAnulados != null && RangoAnulados.Count != 0; }

        public Resumen()
        {
            RangoAnulados = new List<RangoAnulados>();
            RangoUtilizados = new List<RangoUtilizados>();
        }
    }
}
