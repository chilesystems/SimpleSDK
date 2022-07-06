using Newtonsoft.Json;

namespace SimpleSDK.Models.Folios
{
    public class RespuestaFolio
    {
        [JsonIgnore]
        public int MaximoPermitido { get; set; }
        public string Mensaje { get; set; }
        [JsonIgnore]
        public int CantidadSolicitada { get; set; }

        public RespuestaFolio(string mensaje)
        {
            Mensaje = mensaje;
        }
    }
}
