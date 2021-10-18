using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class OtraMoneda
    {
        /// <summary>
        /// Tipo tra moneda.
        /// Tabla de monedas de aduana.
        /// Moneda alternativa en que se expresan los montos totales.
        /// </summary>
        [XmlElement("TpoMoneda")]
        public Enum.CodigosAduana.Moneda TipoMoneda { get; set; }
        public bool ShouldSerializeTipoMoneda() { return TipoMoneda != Enum.CodigosAduana.Moneda.NotSet; }

        [XmlIgnore]
        private double _tipoCambio;
        /// <summary>
        /// Tipo de cambio fijado por el Banco Central de Chile.
        /// 1. Factor de conversión utilizado de pesos a Otra moneda 
        /// 2. 6 enteros y 4 decimales 
        /// 3. En documentos de Exportación corresponde al tipo de cambio de la fecha de emisión del documento, publicado por el Banco Central de Chile. 
        /// </summary>
        [XmlElement("TpoCambio")]
        public double TipoCambio { get { return Math.Round(_tipoCambio, 4); } set { _tipoCambio = value; } }
        public bool ShouldSerializeTipoCambio() { return TipoCambio != 0; }

        [XmlIgnore]
        private double _montoNeto;
        /// <summary>
        /// Monto neto del DTE en otra moneda.
        /// Suma de valores total de ítems afectos en Otra Moneda - descuentos globales en Otra Moneda + recargos globales en Otra Moneda (Asignados a ítems afectos en Otra Moneda).
        /// Si está encendido el Indicador de Montos Brutos (=1) entonces el resultado anterior se debe dividir por (1 + tasa de IVA)
        /// </summary>
        [XmlElement("MntNetoOtrMnda")]
        public double MontoNeto { get { return Math.Round(_montoNeto, 4); } set { _montoNeto = value; } }
        public bool ShouldSerializeMontoNeto() { return MontoNeto != 0; }

        [XmlIgnore]
        private double _montoExento;
        /// <summary>
        /// Monto exento del DTE en otra moneda.
        /// Suma de valores total de ítems no afectos o exentos en Otra Moneda - descuentos globales en Otra Moneda + recargos globales en Otra Moneda (Asignados a ítems exentos o no afectos en Otra Moneda)
        /// </summary>
        [XmlElement("MntExeOtrMnda")]
        public double MontoExento { get { return Math.Round(_montoExento, 4); } set { _montoExento = value; } }
        public bool ShouldSerializeMontoExento() { return MontoExento != 0; }

        [XmlIgnore]
        private double _montoBaseFaenamientoCarne;
        /// <summary>
        /// Monto base faenamiento carne en otra moneda.
        /// Monto informado.
        /// </summary>
        [XmlElement("MntFaeCarneOtrMnda")]
        public double MontoBaseFaenamientoCarne { get { return Math.Round(_montoBaseFaenamientoCarne, 4); } set { _montoBaseFaenamientoCarne = value; } }
        public bool ShouldSerializeMontoBaseFaenamientoCarne() { return MontoBaseFaenamientoCarne != 0; }

        [XmlIgnore]
        private double _montoBaseMargenComercial;
        /// <summary>
        /// Monto base de márgenes de comercialización. 
        /// Monto informado.
        /// </summary>
        [XmlElement("MntMargComOtrMnda")]
        public double MontoBaseMargenComercial { get { return Math.Round(_montoBaseMargenComercial, 4); } set { _montoBaseMargenComercial = value; } }
        public bool ShouldSerializeMontoBaseMargenComercial() { return MontoBaseMargenComercial != 0; }

        [XmlIgnore]
        private double _IVA;
        /// <summary>
        /// Monto del IVA del DTE en otra moneda.
        /// </summary>
        [XmlElement("IVAOtrMnda")]
        public double IVA { get { return Math.Round(_IVA, 4); } set { _IVA = value; } }
        public bool ShouldSerializeIVA() { return IVA != 0; }

        /// <summary>
        /// Impuestos y retenciones adicionales.
        /// </summary>
        [XmlElement("ImpRetOtrMnda")]
        public List<ImpuestosRetencionesOtraMoneda> ImpuestosRetenciones { get; set; }
        public bool ShouldSerializeImpuestosRetenciones() { return ImpuestosRetenciones == null ? false : ImpuestosRetenciones.Count == 0 ? false : true; }

        [XmlIgnore]
        private double _IVANoRetenido;
        /// <summary>
        /// Monto del IVA no retenido en otra moneda.
        /// </summary>
        [XmlElement("IVANoRetOtrMnda")]
        public double IVANoRetenido { get { return Math.Round(_IVANoRetenido, 4); } set { _IVANoRetenido = value; } }
        public bool ShouldSerializeIVANoRetenido() { return IVANoRetenido != 0; }

        [XmlIgnore]
        private double _montoTotal;
        /// <summary>
        /// Monto total del DTE en otra moneda.
        /// </summary>
        [XmlElement("MntTotOtrMnda")]
        public double MontoTotal { get { return Math.Round(_montoTotal, 4); } set { _montoTotal = value; } }
        public bool ShouldSerializeMontoTotal() { return true; }
        public OtraMoneda()
        {
            TipoMoneda = Enum.CodigosAduana.Moneda.NotSet;
            MontoTotal = 0;
            TipoCambio = 0;
            MontoNeto = 0;
            MontoExento = 0;
            MontoBaseFaenamientoCarne = 0;
            MontoBaseMargenComercial = 0;
            IVA = 0;
            ImpuestosRetenciones = null;
            IVANoRetenido = 0;
        }
    }
}
