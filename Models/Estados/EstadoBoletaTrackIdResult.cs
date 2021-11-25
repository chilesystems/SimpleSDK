using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Models.Estados
{
    public class EstadoBoletaTrackIdResult
    {
        [JsonProperty("rut_emisor")]
        public string RutEmisor { get; set; }
        [JsonProperty("rut_envia")]
        public string RutEnvia { get; set; }
        public long TrackId { get; set; }
        [JsonProperty("fecha_recepcion")]
        public string FechaRecepcion { get; set; }
        public string Estado { get; set; }

        public string Response { get; set; }
        public List<EstadoEnvioBoletaEstadistica> Estadistica { get; set; }

        [JsonProperty("detalle_rep_rech")]
        public List<EstadoEnvioBoletaDetalleReparosYRechazos> Detalles { get; set; }
    }

    public class EstadoEnvioBoletaEstadistica
    {
        public int Tipo { get; set; }
        public int Informados { get; set; }
        public int Aceptados { get; set; }
        public int Rechazados { get; set; }
        public int Reparos { get; set; }
    }

    public class EstadoEnvioBoletaDetalleReparosYRechazos
    {
        public int? Tipo { get; set; }
        public int? Folio { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        [JsonProperty("error")]
        public List<EstadoEnvioBoletaError> Errores { get; set; }
    }

    public class EstadoEnvioBoletaError
    {
        [JsonProperty("seccion")]
        public string Seccion { get; set; }
        public int Linea { get; set; }
        public int Nivel { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Detalle { get; set; }
    }
}
