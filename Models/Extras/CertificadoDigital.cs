using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Models.Extras
{
    public class CertificadoDigital
    {
        //public string Nombre { get; set; }
        public string Ruta { get; set; }
        public string Password { get; set; }
        public string Rut { get; set; }
        public int RutCuerpo { get { return int.Parse(Rut.Substring(0, Rut.Length - 2)); } }
        public string RutDV { get { return Rut.Substring(Rut.Length - 1); } }
    }
}
