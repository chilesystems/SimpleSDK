using Newtonsoft.Json;
using System.Collections.Generic;

namespace BHE.Models
{
    public class RegionesData
    {
        [JsonProperty("Regiones")]
        public List<Region> Regiones { get; set; }
    }

    public class Region
    {
        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("Comunas")]
        public List<string> Comunas { get; set; }
    }
}
