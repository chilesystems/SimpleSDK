using System.Security.Cryptography.X509Certificates;

namespace SimpleSDK.Models.RCOF
{
    public class ConsumoFolios
    {
        public DocumentoConsumoFolios DocumentoConsumoFolios { get; set; }

        public ConsumoFolios()
        {
            DocumentoConsumoFolios = new DocumentoConsumoFolios();
        }
    }
}
