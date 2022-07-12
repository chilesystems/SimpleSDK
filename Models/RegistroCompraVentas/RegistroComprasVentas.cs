using Newtonsoft.Json;

namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class RegistroComprasVentas
    {
        public Caratula Caratula { get; set; }
        
        public Compras Compras { get; set; }

        public Ventas Ventas { get; set; }

        public RegistroComprasVentas()
        {
            Caratula = new Caratula();
        }
    }
}