using SimpleSDK.Models.Extras;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SimpleSDK.Models.RCOF
{
    public class ConsumoFolios
    {
        public Caratula Caratula { get; set; }

        public List<Resumen> Resumenes { get; set; }
        public CertificadoDigital Certificado { get; set; }
        public ConsumoFolios()
        {
            Caratula = new Caratula();
            Resumenes = new List<RCOF.Resumen>();
            Certificado = new CertificadoDigital();
        }

    }
}
