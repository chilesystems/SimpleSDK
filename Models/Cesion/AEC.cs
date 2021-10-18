using SimpleSDK.Models.Extras;

namespace SimpleSDK.Models.Cesion
{
    public class AEC
    {
        public DocumentoAEC DocumentoAEC { get; set; }
        /// <summary>
        /// Corresponde a los datos del certificado digital. Se debe indicar la ruta del archivo pfx y su contraseña.
        /// </summary>
        public CertificadoDigital Certificado { get; set; }
        public AEC()
        {
            DocumentoAEC = new DocumentoAEC();
            Certificado = new CertificadoDigital();
        }
    }
}
