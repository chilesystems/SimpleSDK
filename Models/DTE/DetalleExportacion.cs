using SimpleSDK.Helpers;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class DetalleExportacion
    {
        /// <summary>
        /// Número secuencial de línea.
        /// De 1 a 60.
        /// </summary>
        [XmlElement("NroLinDet")]
        public int NumeroLinea { get; set; }

        /// <summary>
        /// Codificación del item.
        /// Se pueden incluir 5 repeticiones de pares código-valor.
        /// </summary>
        [XmlElement("CdgItem")]
        public List<CodigoItem> CodigosItem { get; set; }
        public bool ShouldSerializeCodigosItem() { return CodigosItem == null ? false : CodigosItem.Count == 0 ? false : true; }

        /// <summary>
        /// Indicador de exención/facturación.
        /// Indica si el producto o servicio es exento o no afecto a impuesto o si ya ha sido facturado. (También se utiliza para indicar garantía de depósito por envases. 
        /// Art.28,Inc3 Reglamento DL 825) (Cervezas, Jugos, Aguas Minerales, Bebidas Analcohólicas u otros autorizados por Resolución especial).
        /// Si todos los ítems de una factura tienen valor 1 en este indicador la factura no puede ser factura electrónica (código 33), debería ser factura exenta (código 34).
        /// Sólo en caso de Liquidación-Factura que tenga ítems no facturables negativos, se debe señalar el indicador 2, e informar el valor con signo negativo
        /// </summary>
        [XmlElement("IndExe")]
        public Enum.IndicadorFacturacionExencionEnum IndicadorExento { get; set; }
        public bool ShouldSerializeIndicadorExento() { return IndicadorExento != Enum.IndicadorFacturacionExencionEnum.NotSet; }

        /// <summary>
        /// Sólo para transacciones realizadas por agentes retenedores. No aplica para facturas de exportación
        /// </summary>
        [XmlElement("Retenedor")]
        public Retenedor Retenedor { get; set; }
        public bool ShouldSerializeRetenedor() { return Retenedor != null; }

        [XmlIgnore]
        private string _nombre;
        /// <summary>
        /// Nombre del producto o servicio.
        /// </summary>
        [XmlElement("NmbItem")]
        public string Nombre { get { return _nombre.Truncate(80); } set { _nombre = value; } }

        [XmlIgnore]
        private string _descripcion;
        /// <summary>
        /// Descripción del item.
        /// Descripción Adicional del producto o servicio. Se utiliza para pack, servicios con detalle.
        /// </summary>
        [XmlElement("DscItem")]
        public string Descripcion { get { return _descripcion.Truncate(1000); } set { _descripcion = value; } }
        public bool ShouldSerializeDescripcion() { return !String.IsNullOrEmpty(Descripcion); }

        [XmlIgnore]
        private double _cantidadUnidadMedidaReferencia;
        /// <summary>
        /// Cantidad para la unidad de medida de referencia.
        /// No se usa para el cálculo del valor neto.
        /// Obligatorio para facturas de venta o compra que indican emisor opera como Agente Retenedor.
        /// En Guías de Despacho, y en Indicador de tipo de transporte 8 o 9, es obligatoria si el campo Cantidad no está en la unidad Kgs brutos.
        /// </summary>
        [XmlElement("QtyRef")]
        public double CantidadUnidadMedidaReferencia { get { return Math.Round(_cantidadUnidadMedidaReferencia, 6); } set { _cantidadUnidadMedidaReferencia = value; } }
        public bool ShouldSerializeCantidadUnidadMedidaReferencia() { return CantidadUnidadMedidaReferencia != 0; }

        [XmlIgnore]
        private string _unidadMedidaReferencia;
        /// <summary>
        /// Unidad de medida de referencia.
        /// Glosa con unidad de medida de referencia Obligatorio para facturas de venta, compra o notas que indican emisor opera como Agente Retenedor.
        /// En Guías de Despacho con Indicador de tipo de Traslado de Bienes 8 o 9, es obligatoria si el campo Cantidad no está en la unidad Kgs brutos. 
        /// Adicionalmente en dicho caso se debe utilizar tabla de unidades de Aduanas.
        /// </summary>
        [XmlElement("UnmdRef")]
        public string UnidadMedidaReferencia { get { return _unidadMedidaReferencia.Truncate(4); } set { _unidadMedidaReferencia = value; } }
        public bool ShouldSerializeUnidadMedidaReferencia() { return !String.IsNullOrEmpty(UnidadMedidaReferencia); }

        [XmlIgnore]
        private double _precioUnitarioUnidadMedidaReferencia;
        /// <summary>
        /// Precio unitario de referencia para unidad de medida de referencia.
        /// No se usa para el cálculo del valor neto.
        /// Obligatorio para facturas de venta, compra o notas que indican emisor opera como Agente Retenedor.
        /// </summary>
        [XmlElement("PrcRef")]
        public double PrecioUnitarioUnidadMedidaReferencia { get { return Math.Round(_precioUnitarioUnidadMedidaReferencia, 6); } set { _precioUnitarioUnidadMedidaReferencia = value; } }
        public bool ShouldSerializePrecioUnitarioUnidadMedidaReferencia() { return PrecioUnitarioUnidadMedidaReferencia != 0; }

        [XmlIgnore]
        private double _cantidad;

        /// <summary>
        /// Cantidad del ítem.
        /// Obligatorio para facturas de venta, compra o notas que indican emisor opera como Agente Retenedor
        /// </summary>
        [XmlElement("QtyItem")]
        public double Cantidad { get { return Math.Round(_cantidad, 6); } set { _cantidad = value; } }
        public bool ShouldSerializeCantidad() { return Cantidad != 0; }

        /// <summary>
        /// Distribución de la cantidad.
        /// </summary>
        [XmlElement("Subcantidad")]
        public List<SubCantidad> Subcantidades { get; set; }
        public bool ShouldSerializeSubcantidades() { return Subcantidades == null ? false : Subcantidades.Count == 0 ? false : true; }

        /// <summary>
        /// Fecha de elaboración del item. (AAAA-MM-DD).
        /// Do not set this property, set FechaElaboracion instead.
        /// </summary>
        [XmlElement("FchElabor")]
        public string FechaElaboracionString { get; set; }
        public bool ShouldSerializeFechaElaboracionString() { return FechaElaboracion != DateTime.MinValue; }
        /// <summary>
        /// Fecha de elaboracion del item. (AAAA-MM-DD)
        /// </summary>
        [XmlIgnore]
        public DateTime FechaElaboracion { get { return DateTime.Parse(FechaElaboracionString); } set { FechaElaboracionString = value.ToString("yyyy-MM-dd"); } }

        /// <summary>
        /// Fecha de vencimiento del item. (AAAA-MM-DD).
        /// Do not set this property, set FechaVencimiento instead.
        /// </summary>
        [XmlElement("FchVenc")]
        public string FechaVencimientoString { get; set; }
        public bool ShouldSerializeFechaVencimientoString() { return FechaVencimiento != DateTime.MinValue; }
        /// <summary>
        /// Fecha de vencimiento del item. (AAAA-MM-DD).
        /// </summary>
        [XmlIgnore]
        public DateTime FechaVencimiento { get { return DateTime.Parse(FechaVencimientoString); } set { FechaVencimientoString = value.ToString("yyyy-MM-dd"); } }

        [XmlIgnore]
        private string _unidadMedida;
        /// <summary>
        /// Unidad de medida.
        /// Obligatorio para facturas de venta, compra o notas que indican emisor opera como Agente Retenedor.
        /// Obligatorio en Guías de Despacho con Indicador de tipo de Traslado de Bienes = 8 y 9.
        /// En Facturas de Exportación Campo obligatorio a excepción cuando en el “Indicador de Servicio” se registra el valor 3, 4 o 5. 
        /// En dicho caso se debe utilizar tabla de unidades de Aduanas.
        /// </summary>
        [XmlElement("UnmdItem")]
        public string UnidadMedida { get { return _unidadMedida.Truncate(4); } set { _unidadMedida = value; } }
        public bool ShouldSerializeUnidadMedida() { return !String.IsNullOrEmpty(UnidadMedida); }

        [XmlIgnore]
        private double _precio;
        /// <summary>
        /// Precio unitario del item en pesos.
        /// </summary>
        [XmlElement("PrcItem")]
        public double Precio { get { return _precio; } set { _precio = value; } }
        public bool ShouldSerializePrecio() { return Precio != 0; }

        /// <summary>
        /// Precio del item en otra moneda.
        /// </summary>
        [XmlElement("OtrMnda")]
        public OtraMonedaDetalle OtraMoneda { get; set; }
        public bool ShouldSerializeOtraMoneda() { return OtraMoneda != null; }

        [XmlIgnore]
        private double _descuentoPorcentaje;
        /// <summary>
        /// Porcentaje de descuento.
        /// </summary>
        [XmlElement("DescuentoPct")]
        public double DescuentoPorcentaje { get { return Math.Round(_descuentoPorcentaje, 2); } set { _descuentoPorcentaje = value; } }
        public bool ShouldSerializeDescuentoPorcentaje() { return DescuentoPorcentaje != 0; }

        /// <summary>
        /// Monto del descuento.
        /// </summary>
        [XmlElement("DescuentoMonto")]
        public int Descuento { get; set; }
        public bool ShouldSerializeDescuento() { return Descuento != 0; }

        /// <summary>
        /// Desglose del descuento.
        /// Máximo 5 ítemes de subdescuento.
        /// </summary>
        [XmlElement("SubDscto")]
        public List<SubDescuento> SubDescuentos { get; set; }
        public bool ShouldSerializeSubDescuentos() { return SubDescuentos == null ? false : SubDescuentos.Count == 0 ? false : true; }

        [XmlIgnore]
        private double _recargoPorcentaje;
        /// <summary>
        /// Porcentaje de recargo.
        /// </summary>
        [XmlElement("RecargoPct")]
        public double RecargoPorcentaje { get { return Math.Round(_recargoPorcentaje, 2); } set { _recargoPorcentaje = value; } }
        public bool ShouldSerializeRecargoPorcentaje() { return RecargoPorcentaje != 0; }

        /// <summary>
        /// Monto de recargo.
        /// </summary>
        [XmlElement("RecargoMonto")]
        public int Recargo { get; set; }
        public bool ShouldSerializeRecargo() { return Recargo != 0; }

        /// <summary>
        /// Desglose del recargo.
        /// Máximo 5 ítemes de subrecargo.
        /// </summary>
        [XmlElement("SubRecargo")]
        public List<SubRecargo> SubRecargos { get; set; }
        public bool ShouldSerializeSubRecargos() { return SubRecargos == null ? false : SubRecargos.Count == 0 ? false : true; }

        /// <summary>
        /// Codigo de impuesto adicional o retención. No aplica para facturas de exportación.
        /// Indica el código según tabla de códigos (Ver en Índice 4.- Codificación Tipos de Impuesto). 
        /// </summary>
        [XmlElement("CodImpAdic")]
        public List<Enum.TipoImpuesto.TipoImpuestoEnum> CodigoImpuestoAdicional { get; set; }
        public bool ShouldSerializeCodigoImpuestoAdicional() { return CodigoImpuestoAdicional == null ? false : CodigoImpuestoAdicional.Count == 0 ? false : true; }

        /// <summary>
        /// Monto por línea de detalle, corresponde al monto neto, a menos que sea MntBruto indique lo contrario.
        /// (Precio Unitario * Cantidad ) – Monto Descuento + Monto Recargo.
        /// Valor numérico, de acuerdo con descripción y:
        /// 1) Debe ser cero cuando:
        ///  - Indicador de facturación/ exención tiene valor 4 o 5.
        ///  - Es una Nota de Crédito tipo fe de erratas.(Ver campo Código de Referencia en Referencias).
        /// 2) Puede ser cero cuando el documento es una Guía de despacho NO VENTA (Según campo Indicador Tipo de traslado de bienes del encabezado).
        /// 3) En liquidaciones factura puede ser negativo.
        /// CUANDO ES CERO PUEDE NO IMPRIMIRSE o Imprimirse un texto explicatorio (s/valor, sin costo, etc).
        /// </summary>
        [XmlElement("MontoItem")]
        public double MontoItem { get { return Math.Round(_montoItem, 6); } set { _montoItem = value; } }
        [XmlIgnore]
        private double _montoItem;

        public DetalleExportacion()
        {
            NumeroLinea = 0;
            Nombre = string.Empty;
            MontoItem = 0;
            CodigosItem = null;
            IndicadorExento = Enum.IndicadorFacturacionExencionEnum.NotSet;
            Retenedor = null;
            Descripcion = string.Empty; ;
            CantidadUnidadMedidaReferencia = 0;
            UnidadMedidaReferencia = string.Empty;
            PrecioUnitarioUnidadMedidaReferencia = 0;
            Cantidad = 0;
            Subcantidades = null;
            FechaElaboracion = DateTime.MinValue;
            FechaVencimiento = DateTime.MinValue;
            UnidadMedida = string.Empty;
            Precio = 0;
            OtraMoneda = null;
            DescuentoPorcentaje = 0;
            Descuento = 0;
            SubDescuentos = null;
            RecargoPorcentaje = 0;
            Recargo = 0;
            SubRecargos = null;
            CodigoImpuestoAdicional = null;
        }
    }
}
