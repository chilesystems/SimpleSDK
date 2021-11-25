using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Models.Estados
{
    public class EstadoDTEResult
    {
        public string Response { get; set; }
        public string Estado { get; set; }

        public bool Ok { get { return Estado == "DOK"; } }

        public string GlosaEstado { get; set; }
        public string ERR_CODE { get; set; }
        public string Glosa_ERR_CODE { get; set; }

        public int NumeroAtencion { get; set; }
        public DateTime FechaAtencion { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
    }
}
