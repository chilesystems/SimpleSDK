using System;
using Newtonsoft.Json;

namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class Caratula
    {
        public string RutEmpresa { get; set; }
        public string NombreMes { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int? Dia { get; set; }

        public string Periodo { get { return Anio.ToString() + Mes.ToString().PadLeft(2, '0'); } }
        
        [JsonIgnore]
        public DateTime Fecha { get { return new DateTime(Anio, Mes, (Dia.HasValue ? Dia.Value : 1)); } }
    }
}