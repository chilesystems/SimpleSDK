namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class BasicData
    {
        public string RutCertificado { get; set; }
        public string Password { get; set; }
        public string RutEmpresa { get; set; }
        public int Ambiente { get; set; }
        public byte[] CertificadoB64 { get; set; }
        public BasicData()
        { }
    }
}