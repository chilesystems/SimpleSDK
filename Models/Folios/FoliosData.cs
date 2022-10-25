using SimpleSDK.Models.RegistroCompraVentas;

namespace SimpleSDK.Models.Folios
{
    public class FoliosData : BasicData
    {
        public string RutCertificado { get; set; }
        public string Password { get; set; }
        public int Tipo { get; set; }
        public string MotivoAnulacion { get; set; }
    }
}