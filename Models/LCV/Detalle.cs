using SimpleSDK.Models.DTE;
using System;
using System.Collections.Generic;

namespace SimpleSDK.Models.LCV
{
    public class Detalle
    {
        public long Folio { get; set; }

        /// <summary>
        /// Tipo de documento
        /// </summary>
        public Enum.TipoDTE.DTEType TipoDocumento { get; set; }

        //[XmlIgnore]
        //public Enum.TipoLibro.TipoLibroOrigen TipoLibro { get; set; }
        /// <summary>
        /// Indica si nota de débito o nota de crédito afecta a una factura de compra.
        /// ??
        /// </summary>
        public int Emisor { get; set; }

        /// <summary>
        /// Indica si nota de debito o notade credito afecta a una factura de compra
        /// ??
        /// </summary>
        public int IndicadorFacturaCompra { get; set; }

        /// <summary>
        /// Identificador o folio del documento.
        /// </summary>
        public long NumeroDocumento { get; set; }

        /// <summary>
        /// Indica que el estado del documento es Anulado.
        /// </summary>
        public Enum.IndicadorAnulado.IndicadorAnuladoEnum IndicadorAnulado { get; set; }

        /// <summary>
        /// Indica si agrega o elimina información
        /// </summary>
        public Enum.OperacionDetalle.OperacionDetalleEnum Operacion { get; set; }

        /// <summary>
        /// Tipo de impuesto usado en la operacion (LC).
        /// </summary>
        public Enum.TipoImpuesto.TipoImpuestoResumido TipoImpuesto { get; set; }
        /// <summary>
        /// Tasa de impuesto usada en la operación.
        /// 3 enteros, dos decimales.
        /// 1 - 100.
        /// Se debe registrar la tasa del IVA  o del DL 18.211.
        /// </summary>
        public double TasaImpuestoOperacion { get; set; }

        /// <summary>
        /// Número interno.
        /// Referencia del comprobante
        /// </summary>
        public string NumeroInterno { get; set; }

        /// <summary>
        /// Indica si corresponde a un servicio (LV).
        /// 
        /// </summary>
        public Enum.IndicadorServicio.IndicadorServicioDetalleLibroEnum IndicadorServicio { get; set; }

        /// <summary>
        /// Indicador de venta sin costo (LV).
        /// </summary>
        public Enum.IndicadorSinCosto.IndicadorSinCostoEnum IndicadorSinCosto { get; set; }

        /// <summary>
        /// Fecha del documento. AAAA-MM-DD
        /// </summary>
        public DateTime FechaDocumento { get; set; }

        /// <summary>
        /// Fecha del documento. AAAA-MM-DD
        /// Do not set this property, set FechaDocumento instead.
        /// </summary>
        public string FechaDocumentoString { get; set; }

        /// <summary>
        /// Codigo de Sucursal entregado por el SII.
        /// </summary>
        public int CodigoSucursal { get; set; }

        /// <summary>
        /// Rut del contraparte en la operación comercial
        /// </summary>
        public string RutDocumento { get; set; }

        /// <summary>
        /// Razón social de la contraparte del documento.
        /// </summary>
        public string RazonSocial { get; set; }

        ///// <summary>
        ///// Para factura de exportación: Corresponde al número o código de identificación del receptro extranjero.
        ///// Se deben incluir guiones y dígitos verificadores.
        ///// ??
        ///// </summary>
        //[XmlElement("NumId")]
        //public string NumeroIdentificadorReceptorExtranjero { get; set; }
        //public bool ShouldSerializeNumeroIdentificadorReceptorExtranjero() { return !string.IsNullOrEmpty(NumeroIdentificadorReceptorExtranjero); }

        /// <summary>
        /// Receptor Extranjero (LV).
        /// </summary>
        public Extranjero Extranjero { get; set; }

        /// <summary>
        /// Tipo de documento de referencia (LV)
        /// </summary>
        public Enum.TipoDTE.TipoDocumentoLibro TipoDocumentoReferencia { get; set; }

        /// <summary>
        /// Tipo de Operacion Realizada
        /// </summary>
        public Enum.TipoTraslado.TipoTrasladoEnum TipoOperacion { get; set; }


        /// <summary>
        /// Folio del documento de referencia (LV)
        /// </summary>
        public int FolioDocumentoReferencia { get; set; }

        /// <summary>
        /// Monto exento o no gravado del documento.
        /// </summary>
        public int MontoExento { get; set; }

        /// <summary>
        /// Monto neto del documento
        /// </summary>
        public int MontoNeto { get; set; }

        /// <summary>
        /// Monto de IVA del Documento.
        /// </summary>
        public int MontoIva { get; set; }

        /// <summary>
        /// Monto Neto Activo Fijo (LC).
        /// </summary>
        public int MontoNetoActivoFijo { get; set; }

        /// <summary>
        /// IVA de la operación de Activo Fijo.
        /// </summary>
        public int MontoIVAActivoFijo { get; set; }

        /// <summary>
        /// Totales de IVA No Recuperable (LC).
        /// Hasta 5 repeticiones.
        /// </summary>
        public List<TotalIVANoRecuperableDetalle> IVANoRecuperable { get; set; }

        /// <summary>
        /// IVA de compras destinadas en parte a ventas exentas y afectas (LC).
        /// </summary>
        public int IVAUsoComun { get; set; }

        /// <summary>
        /// Sólo nota de crédito fuera de plazo. (LV)
        /// </summary>
        public int IVAFueraPlazo { get; set; }

        /// <summary>
        /// IVA propio en operaciones a cuenta de terceros (LV).
        /// </summary>
        public int IVAPropio { get; set; }

        /// <summary>
        /// IVA por cuenta de terceros (LV).
        /// </summary>
        public int IVATerceros { get; set; }

        /// <summary>
        /// Ley 18.211.
        /// </summary>
        public int Ley18211 { get; set; }

        /// <summary>
        /// Otros impuestos o recargos.
        /// Hasta 20 repeticiones.
        /// </summary>
        public List<ImpuestosDetalle> Impuestos { get; set; }

        /// <summary>
        /// Monto del impuesto sin derecho a crédito. (LC)
        /// </summary>
        public int MontoImpuestosSinDerechoACredito { get; set; }

        /// <summary>
        /// IVA Retenido Total
        /// </summary>
        public int IVARetenidoTotal { get; set; }

        /// <summary>
        /// IVA Retenido Parcial
        /// </summary>
        public int IVARetenidoParcial { get; set; }

        /// <summary>
        /// Crédito 65% Empresas Constructoras (LV)
        /// </summary>
        public int CreditoEmpresaContructora { get; set; }

        /// <summary>
        /// Depósito por Envase (LV).
        /// </summary>
        public int DepositoEnvase { get; set; }

        /// <summary>
        /// Info. Elect. de Venta (LV).
        /// </summary>
        public List<TotalLiquidacionDetalle> TotalLiquidacionDetalle { get; set; }

        /// <summary>
        /// Monto Total del documento.
        /// </summary>
        public int MontoTotal { get; set; }

        /// <summary>
        /// IVA No Retenido.
        /// </summary>
        public int MontoIvaNoRetenido { get; set; }

        /// <summary>
        /// Monto No Facturable (LV)
        /// </summary>
        public int MontoNoFacturable { get; set; }

        /// <summary>
        /// Total monto periodo (LV).
        /// </summary>
        public int MontoPeriodo { get; set; }

        /// <summary>
        /// Venta pasaje Nacional (LV).
        /// </summary>
        public int PasajeNacional { get; set; }

        /// <summary>
        /// Venta pasaje internacional (LV).
        /// </summary>
        public int PasajeInternacional { get; set; }

        /// <summary>
        /// Tabacos - Puros (LC).
        /// </summary>
        public int Tabacos_Puros { get; set; }

        /// <summary>
        /// Tabacos - Cigarrillos
        /// </summary>
        public int Tabacos_Cigarrillos { get; set; }

        /// <summary>
        /// Tabacos - Elaborados
        /// </summary>
        public int Tabacos_Elaborados { get; set; }

        /// <summary>
        /// Impuesto a vehiculo (LC).
        /// </summary>
        public int ImpuestoVehiculo { get; set; }
    }
}