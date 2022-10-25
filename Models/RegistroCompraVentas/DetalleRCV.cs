using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class DetalleRCV
    {
        public string TipoDTEString { get; set; }
        public int TipoDTE { get; set; }
        public string TipoCompra { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string RutProveedor { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string RutCliente { get; set; }
        public string RazonSocial { get; set; }
        public int Folio { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string AcuseRecibo { get; set; }
        public int EstadoAcuse { get; set; }
        public int? MontoExento { get; set; }
        public ulong? MontoNeto { get; set; }
        public int? MontoIvaRecuperable { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? MontoIvaNoRecuperable { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? CodigoIvaNoRecuperable { get; set; }
        public ulong? MontoTotal { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long? MontoNetoActivoFijo { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long? IvaActivoFijo { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long? IvaUsoComun { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long? ImpuestoSinDerechoCredito { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long? IvaNoRetenido { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? TabacosPuros { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? TabacosCigarrillos { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? TabacosElaborados { get; set; }
        public int TotalOtrosImpuestos { get; set; }
        public string ValorOtroImpuesto { get; set; }
        public string TasaOtroImpuesto { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? TipoDocReferencia { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? FolioDocReferencia { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string RutFirmante { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long? TrackId { get; set; }
        public List<Referencia> Referencias { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Referenciado> Referenciado { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Reparo> Reparos { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<OtrosImpuesto> OtrosImpuestos { get; set; }

        private string _estado;
        public string Estado { get => string.IsNullOrEmpty(_estado) ? "Confirmada" : _estado; set => _estado = value; }

        public DetalleRCV()
        {
            Referencias = new List<Referencia>();
            Referenciado = new List<Referenciado>();
            Reparos = new List<Reparo>();
            OtrosImpuestos = new List<OtrosImpuesto>();
        }
    }
}
