using Newtonsoft.Json;

namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class RegistroComprasVentas
    {
        public Caratula Caratula { get; set; }
        
        [JsonIgnore]
        public Compras Compras { get; set; }

        [JsonIgnore]
        public Ventas Ventas { get; set; }

        public RegistroComprasVentas()
        {
            Caratula = new Caratula();
        }
    }
}