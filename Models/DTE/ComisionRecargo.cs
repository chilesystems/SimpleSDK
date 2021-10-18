using System;
using System.Xml.Serialization;
using SimpleSDK.Helpers;

namespace SimpleSDK.Models.DTE
{
    public class ComisionRecargo
    {
        /// <summary>
        /// Número secuencial de la linea.
        /// La obligatoriedad se refiere a que si se incluye esta zona debe haber al menos una línea y este caso debe ir el dato de número de línea. 
        /// </summary>
        [XmlElement("NroLinCom")]
        public int Numero { get; set; }

        /// <summary>
        /// C (Comisión) u O (Otros cargos).
        /// </summary>
        [XmlElement("TipoMovim")]
        public Enum.TipoRecargoComision.TipoRecargoComisionEnum TipoMovimiento { get; set; }

        [XmlIgnore]
        private string _glosa;
        /// <summary>
        /// Especificación de la comisión u otro cargo.
        /// </summary>
        [XmlElement("Glosa")]
        public string Glosa { get { return _glosa.Truncate(60); } set { _glosa = value; } }

        [XmlIgnore]
        private double _tasa;

        /// <summary>
        /// Valor porcentual de la comisión u otro cargo.
        /// </summary>
        [XmlElement("TasaComision")]
        public double Tasa { get { return Math.Round(_tasa, 2); } set { _tasa = value; } }
        public bool ShouldSerializeTasa() { return Tasa != 0; }

        /// <summary>
        /// Valor neto de la comisión u otro cargo.
        /// En Notas de Crédito, Notas de Débito y Facturas de Compra.
        /// Puede ser cero si el Valor Exento es distinto de cero.
        /// En Liquidaciones-Factura puede ser negativo
        /// </summary>
        [XmlElement("ValComNeto")]
        public int ValorNeto { get; set; }

        /// <summary>
        /// Valor no afecto o exento de la comisión u otros cargos.
        /// En Notas de Crédito, Notas de Débito y Facturas de Compra.
        /// Puede ser cero si el Valor Neto es distinto de cero.
        /// En Liquidaciones-Factura puede ser negativo
        /// </summary>
        [XmlElement("ValComExe")]
        public int ValorExento { get; set; }

        /// <summary>
        /// Valor IVA de la comisión u otros cargos.
        /// Valor * Tasa IVA.
        /// En Notas de Crédito, Notas de Débito y Facturas de Compra.
        /// En Liquidaciones-Factura puede ser negativo.
        /// </summary>
        [XmlElement("ValComIVA")]
        public int IVA { get; set; }
        public bool ShouldSerializeIVA() { return IVA != 0; }

        public ComisionRecargo()
        {
            Numero = 0;
            TipoMovimiento = Enum.TipoRecargoComision.TipoRecargoComisionEnum.NotSet;
            Glosa = string.Empty;
            ValorNeto = 0;
            ValorExento = 0;

            Tasa = 0;
            IVA = 0;
        }
    }
}
