using System;
using System.Collections.Generic;
using SimpleSDK.Models.RegistroCompraVentas;

namespace SimpleSDK.Models.BHE
{
    public class BHData : BasicData
    { 
        public string RutEmisor { get; set; }
        public string Correo { get; set; }
        public TipoRetencionEnum Retencion { get; set; }

        public DateTime FechaEmision { get; set; }

        public Receptor Receptor { get; set; }
        public Emisor Emisor { get; set; }

        public List<Detalle> Detalles { get; set; }

        public BHData()
        {
            Retencion = TipoRetencionEnum.Receptor;
            FechaEmision = DateTime.Now;
            Receptor = new Receptor();
            Emisor = new Emisor();
            Detalles = new List<Detalle>();
        }

    }

    public class Emisor
    {
        public int? Direccion { get; set; }

    }

    public class Receptor
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        public int Region { get; set; }
    }

    public class Detalle
    { 
        public string Nombre { get; set; }
        public int Valor { get; set; }
    }
}
