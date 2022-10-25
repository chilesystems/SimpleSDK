using SimpleSDK.Helpers;

namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class RCVData : BasicData
    {     
        public int? Dia { get; set; }
        public int Mes { get; set; }
        public string NombreMes { get { return TimeHelper.ObtenerNombreMes(Mes); } }
        public int Anio { get; set; }
        public bool Detallado { get; set; }
        public RCVData()
        { }
    }
}