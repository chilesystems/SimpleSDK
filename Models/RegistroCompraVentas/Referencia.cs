namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class Referencia
    {
        public string RutEmisor { get; set; }
        public string RazonSocial { get; set; }
        public string TipoDoc { get; set; }
        public int Folio { get; set; }
        public string FechaEmision { get; set; }
        public string RutReceptor { get; set; }
        public string RazonSocialReceptor { get; set; }
        public int Iva { get; set; }
        public int MontoTotal { get; set; }
    }
}