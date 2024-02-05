using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Models.Envios
{
    public class EnvioResult
    {
        public string RutEnvia { get; set; }
        public string RutEmpresa { get; set; }
        public string File { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public bool Ok { get; set; }

        public string Glosa { get; set; }

        public string Errores { get; set; }
        public long TrackId { get; set; }

        public string ResponseXml { get; set; }

        public override string ToString()
        {
            return $"Estado: {Estado} - TrackID: ${TrackId}. ResponseXml: {ResponseXml}. ";
        }
    }
}
