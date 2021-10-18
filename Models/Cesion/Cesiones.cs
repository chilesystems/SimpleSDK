using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.Cesion
{
    public class Cesiones
    {

        [XmlElement("Cesiones")]
        public List<Cesion> Cesion { get; set; }

        //[XmlIgnore]
        //public List<string> CesionesFirmadas { get; set; }

        public Cesiones()
        {
            Cesion = new List<Cesion>();
            //CesionesFirmadas = new List<string>();
        }
    }
}
