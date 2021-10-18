using System;
using System.Xml.Serialization;
using SimpleSDK.Helpers;

namespace SimpleSDK.Models.DTE
{
    public class DescuentosRecargos
    {
        /// <summary>
        /// Número secuencial de línea.
        /// La obligatoriedad se refiere a que si se incluye esta zona debe haber al menos una línea y este caso debe ir el dato de número de línea. 
        /// </summary>
        [XmlElement("NroLinDR")]
        public int Numero { get; set; }

        /// <summary>
        /// Tipo de movimiento.
        /// </summary>
        [XmlElement("TpoMov")]
        public Enum.TipoMovimiento.TipoMovimientoEnum TipoMovimiento { get; set; }

        [XmlIgnore]
        private string _glosa;
        /// <summary>
        /// Descripción del descuento o recargo.
        /// </summary>
        [XmlElement("GlosaDR")]
        public string Descripcion { get { return _glosa.Truncate(45); } set { _glosa = value; } }
        public bool ShouldSerializeDescripcion() { return !String.IsNullOrEmpty(Descripcion); }

        /// <summary>
        /// Unidad en que se expresa el valor.
        /// </summary>
        [XmlElement("TpoValor")]
        public Enum.ExpresionDinero.ExpresionDineroEnum TipoValor { get; set; }

        [XmlIgnore]
        private double _valor;
        /// <summary>
        /// Valor del descuento o recargo
        /// </summary>
        [XmlElement("ValorDR")]
        public double Valor { get { return Math.Round(_valor, 2); } set { _valor = value; } }

        [XmlIgnore]
        private double _valorOtraMoneda;
        /// <summary>
        /// Valor en otra moneda
        /// </summary>
        [XmlElement("ValorDROtrMnda")]
        public double ValorOtraMoneda { get { return Math.Round(_valorOtraMoneda, 4); } set { _valorOtraMoneda = value; } }
        public bool ShouldSerializeValorOtraMoneda() { return ValorOtraMoneda != 0; }

        /// <summary>
        /// Indica si el descuento o recargo es No afecto o no facturable.
        /// </summary>
        [XmlElement("IndExeDR")]
        public Enum.IndicadorExento.IndicadorExentoEnum IndicadorExento { get; set; }
        public bool ShouldSerializeIndicadorExento() { return IndicadorExento != Enum.IndicadorExento.IndicadorExentoEnum.NotSet; }

        public DescuentosRecargos()
        {
            Numero = 0;
            TipoMovimiento = Enum.TipoMovimiento.TipoMovimientoEnum.NotSet;
            Descripcion = string.Empty;
            TipoValor = Enum.ExpresionDinero.ExpresionDineroEnum.NotSet;
            Valor = 0;
            ValorOtraMoneda = 0;
            IndicadorExento = Enum.IndicadorExento.IndicadorExentoEnum.NotSet;
        }
    }
}
