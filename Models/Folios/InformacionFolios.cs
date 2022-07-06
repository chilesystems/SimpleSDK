using System.Collections.Generic;
using System.Linq;

namespace SimpleSDK.Models.Folios
{
    public class InformacionFolios
    {
        public int CantidadCAF { get => Detalles.Count; }
        public int CantidadFoliosDisponibles { get => Detalles.Sum(x => x.CantidadFoliosDisponibles); }
        public int CantidadFoliosPreviamenteAnulados { get => Detalles.Sum(x => x.CantidadFoliosPreviamenteAnulados); }
        public int CantidadFoliosRecibidos { get => Detalles.Sum(x => x.CantidadFoliosRecibidos); }
        public List<DetalleCAF> Detalles { get; set; }

        public InformacionFolios()
        {
            Detalles = new List<DetalleCAF>();
        }
    }
}
