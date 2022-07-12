using System.Collections.Generic;

namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class Compras
    {
        public List<Resumen> Resumenes { get; set; }
        public List<DetalleRCV> DetalleCompras { get; set; }

        public Compras()
        {
            Resumenes = new List<Resumen>();
            DetalleCompras = new List<DetalleRCV>();
        }
    }
}