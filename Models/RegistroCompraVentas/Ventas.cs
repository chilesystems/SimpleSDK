using System.Collections.Generic;

namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class Ventas
    {
        public List<Resumen> Resumenes { get; set; }
        public List<DetalleRCV> DetalleVentas { get; set; }
        
        public Ventas()
        {
            Resumenes = new List<Resumen>();
            DetalleVentas = new List<DetalleRCV>();
        }
    }
}