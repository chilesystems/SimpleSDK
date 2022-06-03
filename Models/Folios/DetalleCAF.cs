using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSDK.Models.Folios
{
    public class DetalleCAF
    {
        public int CantidadFolios { get { return FolioFinalCAF - FolioInicialCAF + 1; } }
        public int FolioInicialCAF { get; set; }
        public int FolioFinalCAF { get; set; }
        public int CantidadFoliosDisponibles { get { return FoliosDisponibles.Sum(x => x.NumeroFolios); } }
        public int CantidadFoliosPreviamenteAnulados { get { return FoliosAnulados.Sum(x=>x.NumeroFolios); } }
        public int CantidadFoliosRecibidos { get { return FoliosRecibidos.Sum(x=>x.NumeroFolios); } }
        public DateTime Fecha { get; set; }
        public List<DetalleFolio> FoliosDisponibles { get; set; }
        public List<DetalleFolio> FoliosRecibidos { get; set; }
        public List<DetalleFolio> FoliosAnulados { get; set; }

        public DetalleCAF()
        {
            FoliosDisponibles = new List<DetalleFolio>();
            FoliosRecibidos = new List<DetalleFolio>();
            FoliosAnulados = new List<DetalleFolio>(); 
        }
    }
}
