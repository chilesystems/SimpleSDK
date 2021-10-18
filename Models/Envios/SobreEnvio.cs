using SimpleSDK.Models.Extras;

namespace SimpleSDK.Models.Envios
{
    public class SobreEnvio
    {
        /// <summary>
        /// Corresponde a los datos del certificado digital. Se debe indicar la ruta del archivo pfx y su contraseña.
        /// </summary>
        public CertificadoDigital Certificado { get; set; }

        /// <summary>
        /// Información del sobre de envío
        /// </summary>
        public Caratula Caratula { get; set; }

        /// <summary>
        /// Indica si el sobre corresponde a boletas u los otros DTE.
        /// </summary>
       // public Enum.TipoSobreEnvio.EnvioType Tipo { get; set; }

        /// <summary>
        /// Indica si se enviará a certificación (pruebas) o producción.
        /// </summary>
        public Enum.Ambiente.AmbienteEnum Ambiente { get; set; }

        public SobreEnvio()
        {
            Caratula = new Caratula();
            Certificado = new CertificadoDigital();
            //Tipo = Enum.TipoSobreEnvio.EnvioType.EnvioDTE;
        }
    }
}
