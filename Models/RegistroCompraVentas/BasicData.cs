namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class BasicData
    {        
        public string PasswordSII { get; set; }
        public string RutEmpresa { get; set; }
        public string RutUsuario { get; set; }
        public int Ambiente { get; set; }
        public byte[] CertificadoB64 { get; set; }
        public BasicData()
        { }
    }
}