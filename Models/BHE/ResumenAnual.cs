using System.Collections.Generic;
using Newtonsoft.Json;

namespace SimpleSDK.Models.BHE
{
    public class ResumenAnual
    {
        public int Anio { get; set; }
        public string Rut { get; set; }
        public List<DetalleItemAnual> Periodos { get; set; }
        public int TotalVigentes { get; set; }
        public int TotalAnuladas { get; set; }
        public int TotalHonorarioBruto { get; set; }
        public int TotalRetencionTerceros { get; set; }
        public int TotalRetencionContribuyente { get; set; }
        public int TotalRetencionLiquido { get; set; }

        public ResumenAnual()
        {
            Periodos = new List<DetalleItemAnual>();
        }

    }

    public class DetalleItemAnual
    {
        public string Mes { get; set; }
        [JsonIgnore]
        public int FolioInicial { get; set; }
        [JsonIgnore]
        public int FolioFinal { get; set; }
        public int CantidadVigentes { get; set; }
        public int CantidadAnuladas { get; set; }
        public int HonorarioBruto { get; set; }
        public int RetencionTerceros { get; set; }
        public int RetencionContribuyente { get; set; }
        public int TotalLiquido { get; set; }
    }
}
