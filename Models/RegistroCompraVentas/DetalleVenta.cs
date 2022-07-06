using System;
using System.Collections.Generic;

namespace SimpleSDK.Models.RegistroCompraVentas
{
    public class DetalleVenta
    {
        public string TipoVenta { get; set; }
        public string RutCliente { get; set; }
        public string RazonSocial { get; set; }
        public int TipoDte { get; set; }
        public long? Folio { get; set; }
        public string FechaEmision { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string FechaReclamo { get; set; }
        public string AcuseRecibo { get; set; }
        public long? MontoExento { get; set; }
        public long? MontoNeto { get; set; }
        public long? MontoIva { get; set; }
        public int TotalOtrosImpuestos { get; set; }
        public long? MontoTotal { get; set; }
        public long? IvaRetenidoTotal { get; set; }
        public long? IvaRetenidoParcial { get; set; }
        public long? IvaNoRetenido { get; set; }
        public long? IvaPropio { get; set; }
        public long? IvaTerceros { get; set; }
        public string RutEmisorLiqFactura { get; set; }
        public long? NetoComisionLiqFactura { get; set; }
        public long? ExentoComisionLiqFactura { get; set; }
        public long? IvaComisionLiqFactura { get; set; }
        public long? IvaFueraPlazo { get; set; }
        public int? TipoDocReferencia { get; set; }
        public long? FolioDocReferencia { get; set; }
        public long? CreditoEmpresaConstructora { get; set; }
        public long? ImpuestoZonaFranca { get; set; }
        public long? GarantiaDepEnvases { get; set; }
        public int? VentaPasajesTransporteNacional { get; set; }
        public int? VentaPasajesTransporteInternacional { get; set; }
        public string NumeroInterno { get; set; }
        public string NceNdeFacturaCompra { get; set; }
        public string RutFirmante { get; set; }
        public long TrackId { get; set; }
        public List<Referencia> Referencias { get; set; }
        public List<Referenciado> Referenciado { get; set; }
        public List<Reparo> Reparos { get; set; }
        public List<OtrosImpuesto> OtrosImpuestos { get; set; }
        public DateTime? FechaAcuseRecibo { get; set; }
        public long? MontoNoFacturable { get; set; }
        public int? IndicadorVentaSinCosto { get; set; }
        public int? IndicadorServicioPeriodico { get; set; }
    }
}