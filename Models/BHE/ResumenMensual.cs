using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSDK.Models.BHE
{
    public class ResumenMensual
    {
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string Rut { get; set; }
        public int CantidadDocumentos => Boletas.Count();
        public int TotalBruto { get { return Boletas.Sum(x => x.Honorarios.Brutos); } }
        public int TotalRetenido => Boletas.Sum(x => x.Honorarios.Retenido);
        public int TotalPagado => Boletas.Sum(x => x.Honorarios.Pagado);
        public int TotalRetencionEmisor => Boletas.Sum(x => x.Honorarios.RetencionEmisor);
        public int TotalRetencionReceptor => Boletas.Sum(x => x.Honorarios.RetencionReceptor);
        public int TotalLiquido => Boletas.Sum(x => x.Honorarios.Liquido);
        public List<DetalleItemMensual> Boletas { get; set; }     
        public ResumenMensual()
        {
            Boletas = new List<DetalleItemMensual>();
        }

    }

    public class DetalleItemMensual
    {
        public BoletaItemMensual Encabezado { get; set; }
        public EmisorItemMensual Emisor { get; set; }
        public ReceptorItemMensual Receptor { get; set; }
        public HonorariosItemMensual Honorarios { get; set; }

        public DetalleItemMensual()
        {
            Encabezado = new BoletaItemMensual();
            Emisor = new EmisorItemMensual();
            Receptor = new ReceptorItemMensual();
            Honorarios = new HonorariosItemMensual();
        }
    }

    public class BoletaItemMensual
    {
        public int Numero { get; set; }
        public string Estado { get; set; }
        public DateTime FechaBoleta { get; set; }
    }

    public class EmisorItemMensual
    {
        public string RazonSocial { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaEmision { get; set; }
        public bool SociedadProfesional { get; set; }

        public string Rut { get; set; }
    }

    public class ReceptorItemMensual
    {
        public string Rut { get; set; }
        public string RazonSocial { get; set; }
    }

    public class HonorariosItemMensual
    { 
        public int Brutos { get; set; }
        public int RetencionEmisor { get; set; }
        public int RetencionReceptor { get; set; }
        public int Liquido { get; set; }
        public int Retenido { get; set; }
        public int Pagado { get; set; }
    }
}
