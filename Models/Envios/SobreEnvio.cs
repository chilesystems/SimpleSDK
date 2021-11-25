using SimpleSDK.Models.Extras;

namespace SimpleSDK.Models.Envios
{
    public class SobreEnvio : EnvioSII
    {

        /// <summary>
        /// Información del sobre de envío
        /// </summary>
        public Caratula Caratula { get; set; }
        public SobreEnvio()
        {
            Caratula = new Caratula();
        }
    }
}
