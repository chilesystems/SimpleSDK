using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class Totales
    {
        [XmlElement("TpoMoneda")]
        public Enum.CodigosAduana.Moneda TipoMoneda { get; set; }
        public bool ShouldSerializeTipoMoneda() { return TipoMoneda != Enum.CodigosAduana.Moneda.NotSet; }

        /// <summary>
        /// Monto neto del DTE.
        /// Suma de valores total de ítems afectos - descuentos globales + recargos globales (Asignados a ítems afectos).
        /// Si está encendido el Indicador de Montos Brutos (=1) entonces el resultado anterior se debe dividir por (1 + tasa de IVA).
        /// </summary>
        [XmlElement("MntNeto")]
        public int MontoNeto { get; set; }
        public bool ShouldSerializeMontoNeto() { return MontoNeto != 0; }

        /// <summary>
        /// Monto exento del DTE.
        /// Suma de valores total de ítems no afectos o exentos - descuentos globales + recargos globales (Asignados a ítems exentos o no afectos).
        /// </summary>
        [XmlElement("MntExe")]
        public int MontoExento { get; set; }
        public bool ShouldSerializeMontoExento() { return MontoExento != 0; }

        /// <summary>
        /// Monto base faenamiento de carne.
        /// Monto informado.
        /// </summary>
        [XmlElement("MntBase")]
        public int MontoBaseFaenamientoCarne { get; set; }
        public bool ShouldSerializeMontoBaseFaenamientoCarne() { return MontoBaseFaenamientoCarne != 0; }

        /// <summary>
        /// Monto base de márgenes de comercialización. Monto informado.
        /// Monto informado.
        /// </summary>
        [XmlElement("MntMargenCom")]
        public int MontoBaseMargenesComercializacion { get; set; }
        public bool ShouldSerializeMontoBaseMargenesComercializacion() { return MontoBaseMargenesComercializacion != 0; }

        /// <summary>
        /// Tasa de IVA.
        /// 3 enteros, 2 decimales. (Ej: 19.5)
        /// </summary>
        [XmlElement("TasaIVA")]
        public double TasaIVA { get; set; }
        public bool ShouldSerializeTasaIVA() { return TasaIVA != 0; }

        /// <summary>
        /// Monto del IVA del DTE.
        /// Monto neto * Tasa IVA.
        /// </summary>
        [XmlElement("IVA")]
        public int IVA { get; set; }
        public bool ShouldSerializeIVA() { return IVA != 0; }

        /// <summary>
        /// Monto del IVA propio.
        /// Las empresas que venden por cuenta de un mandatario.
        /// Pueden opcional separar el IVA en propio y de terceros.
        /// En todos estos casos el campo "IVA" debe contenerl el IVA total de la factura.
        /// </summary>
        [XmlElement("IVAProp")]
        public int IVAPropio { get; set; }
        public bool ShouldSerializeIVAPropio() { return IVAPropio != 0; }

        /// <summary>
        /// Monto del IVA de terceros.
        /// Las empresas que venden por cuenta de un mandatario.
        /// Pueden opcional separar el IVA en propio y de terceros.
        /// En todos estos casos el campo "IVA" debe contenerl el IVA total de la factura.
        /// </summary>
        [XmlElement("IVATerc")]
        public int IVATerceros { get; set; }
        public bool ShouldSerializeIVATerceros() { return IVATerceros != 0; }

        /// <summary>
        /// Impuestos y retenciones adicionales.
        /// </summary>
        [XmlElement("ImptoReten")]
        public List<ImpuestosRetenciones> ImpuestosRetenciones { get; set; }
        public bool ShouldSerializeImpuestosRetenciones() { return ImpuestosRetenciones == null ? false : ImpuestosRetenciones.Count == 0 ? false : true; }

        /// <summary>
        /// IVA no retenido.
        /// Sólo en facturas de Compra en que hay retención de IVA por el emisor y Notas de Crédito o débito que referencian facturas de compra. 
        /// No se registra si es igual a 0.
        /// IVA - IVA retenido por producto.
        /// </summary>
        [XmlElement("IVANoRet")]
        public int IVANoRetenido { get; set; }
        public bool ShouldSerializeIVANoRetenido() { return IVANoRetenido != 0; }

        /// <summary>
        /// Crédito especial para empresas constructoras.
        /// Artículo 21 del decreto ley N° 910/75. 
        /// Este Es el único código que opera en forma opuesta al resto, ya que se resta al IVA general 
        /// </summary>
        [XmlElement("CredEC")]
        public int CreditoEmpresasConstructoras { get; set; }
        public bool ShouldSerializeCreditoEmpresasConstructoras() { return CreditoEmpresasConstructoras != 0; }

        /// <summary>
        /// Garantía por depósito de envases o embalajes.
        /// Sólo para empresas que usen envases en forma habitual, por su giro principal. Art.28,Inc3 Reglamento DL 825. (Cervezas, Jugos, Aguas Minerales, Bebidas Analcohólicas u otros autorizados por Resolución especial).
        /// Corresponde a la Sumatoria de las líneas de detalle que indican Indicador de facturación/exención = 3 (Detalle de garantía de depósito).
        /// </summary>
        [XmlElement("GrntDep")]
        public int GarantiaDepositoEnvasesOEmbalajes { get; set; }
        public bool ShouldSerializeGarantiaDepositoEnvasesOEmbalajes() { return GarantiaDepositoEnvasesOEmbalajes != 0; }

        /// <summary>
        /// Comisiones y otros cargos. Es obligatorio para liquidaciones de factura.
        /// </summary>
        [XmlElement("Comisiones")]
        public List<Comisiones> Comisiones { get; set; }
        public bool ShouldSerializeComisiones() { return Comisiones == null ? false : Comisiones.Count == 0 ? false : true; }

        /// <summary>
        /// Monto total del DTE.
        /// Monto neto + Monto no afecto o exento + IVA + Impuestos Adicionales + Impuestos Específicos + Iva Margen Comercialización + IVA Anticipado + Garantía por depósito de envases o embalajes - Crédito empresas constructoras - IVA Retenido productos (en caso de facturas de compra) - Valor Neto Comisiones y Otros Cargos - IVA Comisiones y Otros Cargos - Valor Comisiones y Otros Cargos No Afectos o Exentos.
        /// (Los Impuestos Adicionales y el IVA Anticipado están detallados en la TABLA de Impuestos Adicionales y Retenciones).
        /// En Documentos de exportación es “0” (cero) si forma de pago es = 21 (Sin pago).
        /// </summary>
        [XmlElement("MntTotal")]
        public int MontoTotal { get; set; }

        /// <summary>
        /// Monto no facturable. 
        /// Corresponde a bienes o servicios facturados previamente.
        /// Suma de montos o bienes o servicios con indicador de facturación/exención = 2 (Producto o servicio no facturable positivo.) menos suma de montos de bienes o servicios con Indicador de facturación/exención = 6 (Producto o servicio no facturable negativo).
        /// </summary>
        [XmlElement("MontoNF")]
        public int MontoNoFacturable { get; set; }
        public bool ShouldSerializeMontoNoFacturable() { return MontoNoFacturable != 0; }

        /// <summary>
        /// Total de ventas o servicios del periodo.
        /// Monto Total + Monto no Facturable
        /// </summary>
        [XmlElement("MontoPeriodo")]
        public int MontoPeriodo { get; set; }
        public bool ShouldSerializeMontoPeriodo() { return MontoPeriodo != 0; }

        /// <summary>
        /// Saldo anterior. Puede ser positivo o negativo.
        /// Se incluye sólo con fines de ilustrar con claridad el cobro.
        /// </summary>
        [XmlElement("SaldoAnterior")]
        public int SaldoAnterior { get; set; }
        public bool ShouldSerializeSaldoAnterior() { return SaldoAnterior != 0; }

        /// <summary>
        /// Valor a pagar total del documento.
        /// Valor cobrado.
        /// </summary>
        [XmlElement("VlrPagar")]
        public int ValorAPagar { get; set; }
        public bool ShouldSerializeValorAPagar() { return ValorAPagar != 0; }

        public Totales()
        {
            TipoMoneda = Enum.CodigosAduana.Moneda.NotSet;
            MontoTotal = 0;
            MontoNeto = 0;
            MontoExento = 0;
            MontoBaseFaenamientoCarne = 0;
            MontoBaseMargenesComercializacion = 0;
            TasaIVA = 0;
            IVA = 0;
            IVAPropio = 0;
            IVATerceros = 0;
            ImpuestosRetenciones = null;
            IVANoRetenido = 0;
            CreditoEmpresasConstructoras = 0;
            GarantiaDepositoEnvasesOEmbalajes = 0;
            Comisiones = null;
            MontoNoFacturable = 0;
            MontoPeriodo = 0;
            SaldoAnterior = 0;
            ValorAPagar = 0;
        }
    }
}
