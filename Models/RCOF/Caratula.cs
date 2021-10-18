using System;

namespace SimpleSDK.Models.RCOF
{
    public class Caratula
    {
        public string RutEmisor { get; set; }
        public string RutEnvia { get; set; }
        public int NroResol { get; set; }
        public string SecEnvio { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaResolucion { get; set; }        
        public DateTime FechaInicio { get; set; }        
        public DateTime FechaFinal { get; set; }

        public Caratula()
        {
        }
    }
}
