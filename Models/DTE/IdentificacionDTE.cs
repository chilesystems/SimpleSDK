using SimpleSDK.Helpers;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static SimpleSDK.Enum.CodigosAduana;

namespace SimpleSDK.Models.DTE
{
    /// <summary>
    /// Identificación del DTE
    /// </summary>
    [XmlRoot("IdDoc")]
    public class IdentificacionDTE
    {
        /// <summary>
        /// Tipo de DTE
        /// </summary>
        [XmlElement("TipoDTE")]
        public Enum.TipoDTE.DTEType TipoDTE { get; set; }

        /// <summary>
        /// Folio del Documento Eletrónico
        /// </summary>
        [XmlElement("Folio")]
        public long Folio { get; set; }

        /// <summary>
        /// Fecha Emisión Contable del DTE (AAAA-MM-DD)
        /// Do not set this property, set FechaEmision instead.
        /// </summary>
        [XmlElement("FchEmis")]
        public string FechaEmisionString { get; set; }

        /// <summary>
        /// Fecha Emisión Contable del DTE.
        /// </summary>
        [XmlIgnore]
        public DateTime FechaEmision { get { return DateTime.Parse(FechaEmisionString); } set { this.FechaEmisionString = value.ToString("yyyy-MM-dd"); } }

        /// <summary>
        /// Sólo para Notas de Crédito que no tienen derecho a Rebaja del Débito.
        /// 1: Nota de crédito sin derecho a descontar débito (Art 70 DL 825 y art. 38 reglamento DL 825.
        /// </summary>
        [XmlElement("IndNoRebaja")]
        public int IndicadorNoRebaja { get; set; }
        public bool ShouldSerializeIndicadorNoRebaja() { return IndicadorNoRebaja != 0; }

        /// <summary>
        /// Indica si el documento acompaña bienes y el despacho es por cuenta del vendedor o del comprador. No se incluye si el documento no acompaña bienes o se trata de una Factura o Nota correspondiente a la prestación de servicios.
        /// </summary>
        [XmlElement("TipoDespacho")]
        public Enum.TipoDespacho.TipoDespachoEnum TipoDespacho { get; set; }
        public bool ShouldSerializeTipoDespacho() { return TipoDespacho != Enum.TipoDespacho.TipoDespachoEnum.NotSet; }

        /// <summary>
        /// Sólo para Guías de despacho.
        /// Indica si el traslado de mercadería es por Venta (valor 1) o por otros motivos que no corresponden a venta. (valores mayores a 1).
        /// 7: Para de devolución de mercaderías que fueron trasladadas para exportación desde la zona de embarque.
        /// 8 y 9: Para exportaciones, cuando se dirige la mercadería hacia el puerto, aeropuerto o aduana de embarque. 
        /// 9 : Entre otros, venta de mercaderías que se entregan en Zona Primaria de Aduanas para su exportación
        /// </summary>
        [XmlElement("IndTraslado")]
        public Enum.TipoTraslado.TipoTrasladoEnum TipoTraslado { get; set; }
        public bool ShouldSerializeTipoTraslado() { return TipoTraslado != Enum.TipoTraslado.TipoTrasladoEnum.NotSet; }

        /// <summary>
        /// Describe modalidad de Impresión de la representación impresa en formato normal o en formato Ticket. Por omisión se asume "N".
        /// </summary>
        [XmlElement("TpoImpresion")]
        public Enum.TipoImpresion.TipoImpresionEnum TipoImpresion { get; set; }
        public bool ShouldSerializeTipoImpresion() { return TipoImpresion != Enum.TipoImpresion.TipoImpresionEnum.N; }
        /// <summary>
        /// Indica si la transacción corresponde a la prestación de un servicio
        /// </summary>
        //[XmlElement("IndServicio")]
        //public Engine.Enum.IndicadorServicio.IndicadorServicioBoletaEnum IndicadorServicioBoleta { get; set; }
        //public bool ShouldSerializeIndicadorServicioBoleta() { return IndicadorServicioBoleta != Enum.IndicadorServicio.IndicadorServicioBoletaEnum.NotSet; }

        [XmlElement(ElementName = "IndServicio", Type = typeof(Enum.IndicadorServicio.IndicadorServicioEnum))]
        public Enum.IndicadorServicio.IndicadorServicioEnum IndicadorServicio { get; set; }
        public bool ShouldSerializeIndicadorServicio() { return IndicadorServicio != Enum.IndicadorServicio.IndicadorServicioEnum.NotSet; }

        /// <summary>
        /// Indica si las líneas de detalle, descuentos y recargos se expresan en montos brutos. (Sólo para documentos sin impuestos adicionales).
        /// 1: Montos de líneas de detalle vienen expresados en montos brutos.
        /// </summary>
        [XmlElement("MntBruto")]
        public int IndicadorMontosBruto { get; set; }
        public bool ShouldSerializeIndicadorMontosBruto() { return IndicadorMontosBruto != 0; }
        /// <summary>
        /// Indica en qué forma se pagará. En el caso de una Factura por “Entrega Gratuita”, se debe indicar el 3. Una Factura de este tipo no tiene derecho a crédito fiscal.
        /// </summary>
        [XmlElement("FmaPago")]
        public Enum.FormaPago.FormaPagoEnum FormaPago { get; set; }
        public bool ShouldSerializeFormaPago() { return FormaPago != Enum.FormaPago.FormaPagoEnum.NotSet; }
        /// <summary>
        /// En el caso de Factura de exportación se refiere a la forma de pago del importador extranjero indicada en el DUS (acreditivo, cobranza, anticipo, contado) En el caso de una Factura de exportación por “Muestras sin carácter comercial”, según las normas de Aduanas, debe indicar el Cod. 21. 
        /// </summary>
        [XmlElement("FmaPagExp")]
        public FormaPagoExportacionEnum FormaPagoExportacion { get; set; }
        public bool ShouldSerializeFormaPagoExportacion() { return FormaPagoExportacion != FormaPagoExportacionEnum.NotSet; }

        /// <summary>
        /// Sólo se utiliza si la factura ha sido cancelada antes de la fecha de emisión. (AAAA-MM-DD).
        /// Campo Obligatorio para Factura de exportación cuando en “Forma de Pago Exportación” se indique “anticipo”
        /// Do not set this property, set FechaCancelacion instead
        /// </summary>
        [XmlElement("FchCancel")]
        public string FechaCancelacionString { get; set; }
        public bool ShouldSerializeFechaCancelacionString() { return FechaCancelacion != DateTime.MinValue; }

        /// <summary>
        /// Sólo se utiliza si la factura ha sido cancelada antes de la fecha de emisión. (AAAA-MM-DD).
        /// Campo Obligatorio para Factura de exportación cuando en “Forma de Pago Exportación” se indique “anticipo”
        /// </summary>
        [XmlIgnore]
        public DateTime FechaCancelacion { get { return DateTime.Parse(FechaCancelacionString); } set { this.FechaCancelacionString = value.ToString("yyyy-MM-dd"); } }

        /// <summary>
        /// Al momento de emitirse el documento.
        /// </summary>
        [XmlElement("MntCancel")]
        public int MontoCancelado { get; set; }
        public bool ShouldSerializeMontoCancelado() { return MontoCancelado != 0; }

        /// <summary>
        /// Al momento de emitirse el documento.
        /// </summary>
        [XmlElement("SaldoInsol")]
        public int SaldoInsoluto { get; set; }
        public bool ShouldSerializeSaldoInsoluto() { return SaldoInsoluto != 0; }

        /// <summary>
        /// Tabla de montos de pago. Opcional para especificar la programación de pagos del documento.
        /// Hasta 30 repeticiones.
        /// </summary>
        [XmlElement("MntPagos")]
        public List<MontoPagoItem> MontosPago { get; set; }
        public bool ShouldSerializeMontosPago() { return MontosPago == null ? false : MontosPago.Count == 0 ? false : true; }

        /// <summary>
        /// Periodo de facturación para servicios periódicos. Fecha desde. AAAA-MM-DD
        /// Fecha inicial del servicio facturado.
        /// Do not set this property, set PeriodoDesde instead.
        /// </summary>
        [XmlElement("PeriodoDesde")]
        public string PeriodoDesdeString { get; set; }
        public bool ShouldSerializePeriodoDesdeString() { return PeriodoDesde != DateTime.MinValue; }

        /// <summary>
        /// Periodo de facturación para servicios periódicos. Fecha desde. AAAA-MM-DD
        /// Fecha inicial del servicio facturado.
        /// Do not set this property, set PeriodoDesde instead.
        /// </summary>
        [XmlIgnore]
        public DateTime PeriodoDesde { get { return DateTime.Parse(PeriodoDesdeString); } set { this.PeriodoDesdeString = value.ToString("yyyy-MM-dd"); } }

        /// <summary>
        /// Periodo de facturación para servicios periódicos. Fecha hasta. AAAA-MM-DD
        /// Fecha final del servicio facturado.
        /// Do not set this property, set PeriodoHasta instead.
        /// </summary>
        [XmlElement("PeriodoHasta")]
        public string PeriodoHastaString { get; set; }
        public bool ShouldSerializePeriodoHastaString() { return PeriodoHasta != DateTime.MinValue; }

        /// <summary>
        /// Periodo de facturación para servicios periódicos. Fecha desde. AAAA-MM-DD
        /// Fecha inicial del servicio facturado.
        /// </summary>
        [XmlIgnore]
        public DateTime PeriodoHasta { get { return DateTime.Parse(PeriodoHastaString); } set { this.PeriodoHastaString = value.ToString("yyyy-MM-dd"); } }

        /// <summary>
        /// Indica en qué modalidad se pagará.
        /// </summary>
        [XmlElement("MedioPago")]
        public Enum.MedioPago.MedioPagoEnum MedioPago { get; set; }
        public bool ShouldSerializeMedioPago() { return MedioPago != Enum.MedioPago.MedioPagoEnum.NotSet; }

        /// <summary>
        /// Tipo de cuenta de pago.
        /// </summary>
        [XmlElement("TpoCtaPago")]
        public Enum.TipoCuentaPago.TipoCuentaPagoEnum TipoCuentaPago { get; set; }
        public bool ShouldSerializeTipoCuentaPago() { return TipoCuentaPago != Enum.TipoCuentaPago.TipoCuentaPagoEnum.NotSet; }

        [XmlIgnore]
        private string _cuentaPago;
        /// <summary>
        /// Numero de la cuenta de pago
        /// </summary>
        [XmlElement("NumCtaPago")]
        public string CuentaPago { get { return _cuentaPago.Truncate(20); } set { _cuentaPago = value; } }
        public bool ShouldSerializeCuentaPago() { return !String.IsNullOrEmpty(CuentaPago); }

        [XmlIgnore]
        private string _bancoPago;
        /// <summary>
        /// Banco de la cuenta de pago
        /// </summary>
        [XmlElement("BcoPago")]
        public string BancoPago { get { return _bancoPago.Truncate(40); } set { _bancoPago = value; } }
        public bool ShouldSerializeBancoPago() { return !String.IsNullOrEmpty(BancoPago); }

        [XmlIgnore]
        private string _terminoPagoCodigo;
        /// <summary>
        /// Es un código acordado entre las empresas, que indica términos de referencia Ejemplos: Fecha Recepción Factura (FRF), o Fecha entrega Mercaderías (FEM), etc. 
        /// </summary>
        [XmlElement("TermPagoCdg")]
        public string TerminosPagoCodigo { get { return _terminoPagoCodigo.Truncate(4); } set { _terminoPagoCodigo = value; } }
        public bool ShouldSerializeTerminosPagoCodigo() { return !String.IsNullOrEmpty(TerminosPagoCodigo); }

        [XmlIgnore]
        private string _terminoPagoGlosa;
        /// <summary>
        /// Glosa que describe las condiciones del pago del documento, codificado en el campo: “Términos del pagoCódigo” 
        /// En documentos de Exportación Es obligatorio si se indicó el campo: Código de termino de pago
        /// </summary>
        [XmlElement("TermPagoGlosa")]
        public string TerminosPagoGlosa { get { return _terminoPagoGlosa.Truncate(100); } set { _terminoPagoGlosa = value; } }
        public bool ShouldSerializeTerminosPagoGlosa() { return !String.IsNullOrEmpty(TerminosPagoGlosa); }

        /// <summary>
        /// Cantidad de días de acuerdo al código de Términos de pago: Ejemplo  5 días Fecha entrega Mercaderías (Día = 5, Código =FEM)
        /// </summary>
        [XmlElement("TermPagoDias")]
        public int TerminosPagoDias { get; set; }
        public bool ShouldSerializeTerminosPagoDias() { return TerminosPagoDias != 0; }

        /// <summary>
        /// Fecha de vencimiento (AAAA-MMDD)
        /// Do not set this property, set FechaVencimiento instead.
        /// </summary>
        [XmlElement("FchVenc")]
        public string FechaVencimientoString { get; set; }
        public bool ShouldSerializeFechaVencimientoString() { return FechaVencimiento != DateTime.MinValue; }

        /// <summary>
        /// Fecha de vencimiento (AAAA-MMDD)
        /// </summary>
        [XmlIgnore]
        public DateTime FechaVencimiento { get { return DateTime.Parse(FechaVencimientoString); } set { this.FechaVencimientoString = value.ToString("yyyy-MM-dd"); } }


        public IdentificacionDTE()
        {
            // IndicadorServicioBoleta = Enum.IndicadorServicio.IndicadorServicioBoletaEnum.NotSet;
            IndicadorServicio = Enum.IndicadorServicio.IndicadorServicioEnum.NotSet;
            IndicadorNoRebaja = 0;
            TipoDespacho = Enum.TipoDespacho.TipoDespachoEnum.NotSet;
            TipoTraslado = Enum.TipoTraslado.TipoTrasladoEnum.NotSet;
            TipoImpresion = Enum.TipoImpresion.TipoImpresionEnum.N;
            IndicadorMontosBruto = 0;
            FormaPago = Enum.FormaPago.FormaPagoEnum.NotSet;
            FormaPagoExportacion = 0;
            FechaCancelacion = DateTime.MinValue;
            MontoCancelado = 0;
            SaldoInsoluto = 0;
            MontosPago = new List<MontoPagoItem>();
            PeriodoDesde = DateTime.MinValue;
            PeriodoHasta = DateTime.MinValue;
            MedioPago = Enum.MedioPago.MedioPagoEnum.NotSet;
            TipoCuentaPago = Enum.TipoCuentaPago.TipoCuentaPagoEnum.NotSet;
            CuentaPago = string.Empty;
            BancoPago = string.Empty;
            TerminosPagoCodigo = string.Empty;
            TerminosPagoGlosa = string.Empty;
            TerminosPagoDias = 0;
            FechaVencimiento = DateTime.MinValue;
        }
    }
}
