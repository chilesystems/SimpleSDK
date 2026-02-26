namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class BasicData
    {
        /*public string PasswordSII { get; set; }
        public string RutEmpresa { get; set; }
        public string RutUsuario { get; set; }
        public int Ambiente { get; set; }
        public byte[] CertificadoB64 { get; set; }
        public BasicData()
        { }*/

        public string RutCertificado { get; set; }
        public string Password { get; set; }
        public string RutUsuario { get; set; }
        public string PasswordSII { get; set; }
        public string RutEmpresa { get; set; }
        public int Ambiente { get; set; }
        public byte[] CertificadoB64 { get; set; }
        public bool Detallado { get; set; }

        public BasicData()
        {
            PasswordSII = string.Empty;
            RutUsuario = string.Empty;
            RutEmpresa = string.Empty;
            RutCertificado = string.Empty;
            Password = string.Empty;
            Detallado = false;
        }
    }
}