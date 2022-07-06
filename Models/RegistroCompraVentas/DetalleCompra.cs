using System;
using System.Collections.Generic;
using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;

namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class DetalleCompra
    {
        [Index(1)]
        public string TipoDte { get; set; }

        [Index(2)]
        public string TipoCompra { get; set; }
        [Index(3)]
        public string RutProveedor { get; set; }
        [Index(4)]
        public string RazonSocial { get; set; }
        [Index(5)]
        public long? Folio { get; set; }
        [Index(6)]
        public string FechaEmision { get; set; }
        [Index(7)]
        public DateTime? FechaRecepcion { get; set; }
        [Index(8)]
        [JsonIgnore]
        public string AcuseRecibo { get; set; }
        [Ignore]
        public int EstadoAcuse { get; set; }
        [Index(9)]
        public long? MontoExento { get; set; }
        [Index(10)]
        public long? MontoNeto { get; set; }
        [Index(11)]
        public long? MontoIvaRecuperable { get; set; }
        [Index(12)]
        [JsonIgnore]
        public long? MontoIvaNoRecuperable { get; set; }
        [Index(13)]
        [JsonIgnore]
        public int? CodigoIvaNoRecuperable { get; set; }
        [Index(14)]
        public long? MontoTotal { get; set; }
        [Index(15)]
        [JsonIgnore]
        public long? MontoNetoActivoFijo { get; set; }
        [Index(16)]
        [JsonIgnore]
        public long? IvaActivoFijo { get; set; }
        [Index(17)]
        [JsonIgnore]
        public long? IvaUsoComun { get; set; }
        [Index(18)]
        [JsonIgnore]
        public long? ImpuestoSinDerechoCredito { get; set; }
        [Index(19)]
        [JsonIgnore]
        public long? IvaNoRetenido { get; set; }
        [Index(20)]
        [JsonIgnore]
        public int? TabacosPuros { get; set; }
        [JsonIgnore]
        [Index(21)]
        public int? TabacosCigarrillos { get; set; }
        [Index(22)]
        [JsonIgnore]
        public int? TabacosElaborados { get; set; }
        [Index(23)] 
        public string NceNdeFacturaCompra { get; set; }

        [Index(24)]
        public string CodigoOtroImpuesto { get; set; }
        [Index(25)]
        public string ValorOtroImpuesto { get; set; }
        [Index(26)]
        public string TasaOtroImpuesto { get; set; }
        
        
        //Datos que solo se obtienen desde los click, no desde los csv
        [Ignore]
        [JsonIgnore]
        public int? TipoDocReferencia { get; set; }
        [Ignore]
        [JsonIgnore]
        public string FolioDocReferencia { get; set; }
        [Ignore]
        [JsonIgnore]
        public string RutFirmante { get; set; }
        [Ignore]
        [JsonIgnore]
        public long? TrackId { get; set; }
        public List<Referencia> Referencias { get; set; }
        public List<Referenciado> Referenciado { get; set; }
        public List<Reparo> Reparos { get; set; }
        public List<OtrosImpuesto> OtrosImpuestos { get; set; }

        [Ignore]
        private string _estado;
        [Ignore] 
        public string Estado { get => string.IsNullOrEmpty(_estado) ? "Confirmada" : _estado; set => _estado = value; }  
        public DetalleCompra()
        {
            Referencias = new List<Referencia>();
            Referenciado = new List<Referenciado>();
            Reparos = new List<Reparo>();
            OtrosImpuestos = new List<OtrosImpuesto>();
        }
    }
}