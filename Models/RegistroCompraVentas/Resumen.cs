namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class Resumen
    {
        public int TipoDte { get; set; }
        public string TipoDteString { get; set; }
        public int TotalDocumentos { get; set; }
        public long MontoExento { get; set; }
        public long MontoNeto { get; set; }
        public long IvaRecuperable { get; set; }
        public long IvaUsoComun { get; set; }
        public long IvaNoRecuperable { get; set; }
        public long MontoTotal { get; set; }
        public string Estado { get; set; }
    }
}