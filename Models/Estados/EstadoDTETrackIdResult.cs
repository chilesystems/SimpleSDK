using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Models.Estados
{
    public class EstadoDTETrackIdResult
    {
        public List<Estado> Estados { get; set; }
        public string ResponseXml { get; set; }
        public string Response { get; set; }
        public long TrackId { get; set; }
        public string Estado { get; set; }
        public bool Ok { get { return Estado == "EPR"; } }
        public int NumeroAtencion { get; set; }
        public DateTime FechaAtencion { get; set; }
        private string _glosa; public string SRV_CODE { get; set; }
        public string SQL_CODE { get; set; }
        public string ERR_CODE { get; set; }
        public string Glosa
        {
            get
            {
                if (Estado == "-11")
                    return Resolve_SRV_CODE(SRV_CODE) + Resolve_SQL_CODE(SQL_CODE) + Resolve_ERR_CODE(ERR_CODE);
                else
                    return _glosa;
            }
            set { _glosa = value; }
        }
        private string Resolve_SRV_CODE(string code)
        {
            switch (code)
            {
                case "0": return "Todo Ok.";
                case "1": return "Error en Entrada.";
                case "2": return "Error SQL.";
                default: return string.Empty;
            }
        }

        private string Resolve_SQL_CODE(string code)
        {
            switch (code)
            {
                case "0": return "Schema Validado.";
                case "OTRO": return "ORACLE CODE: " + code;
                default: return string.Empty;
            }
        }

        private string Resolve_ERR_CODE(string code)
        {
            switch (code)
            {
                case "0": return "Se retorna el estado.";
                case "1": return "El envío no es de la Empresa, faltan parámetros de entrada.";
                case "2": return "Error de proceso.";
                default: return string.Empty;
            }
        }

        public EstadoDTETrackIdResult()
        {
            Estados = new List<Estado>();
        }
    }

    public class Estado
    {
        public int TipoDocumento { get; set; }
        public int CantidadInformados { get; set; }
        public int CantidadAceptados { get; set; }
        public int CantidadRechazados { get; set; }
        public int CantidadReparos { get; set; }
    }
}
