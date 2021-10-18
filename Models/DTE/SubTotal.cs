using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using SimpleSDK.Helpers;

namespace SimpleSDK.Models.DTE
{
    public class SubTotal
    {
        /// <summary>
        /// Número de sub-total.
        /// Número secuencial de acuerdo al número de subtotales.
        /// </summary>
        [XmlElement("NroSTI")]
        public int NumeroSubTotal { get; set; }

        [XmlIgnore]
        private string _glosa;
        /// <summary>
        /// Glosa.
        /// Título del subtotal.
        /// </summary>
        [XmlElement("GlosaSTI")]
        public string Glosa { get { return _glosa.Truncate(40); } set { _glosa = value; } }
        
        /// <summary>
        /// Ubicación para impresión.
        /// De uso para el contribuyente como ayuda para indicar cómo se imprimirá los subtotales.
        /// </summary>
        [XmlElement("OrdenSTI")]
        public int Orden { get; set; }
        public bool ShouldSerializeOrden() { return Orden != 0; }

        [XmlIgnore]
        private double _neto;
        /// <summary>
        /// Valor neto del subtotal.
        /// </summary>
        [XmlElement("SubTotNetoSTI")]
        public double Neto { get { return Math.Round(_neto, 2); } set { _neto = value; } }
        public bool ShouldSerializeNeto() { return Neto != 0; }

        [XmlIgnore]
        private double _iva;
        /// <summary>
        /// Valor del IVA del subtotal.
        /// </summary>
        [XmlElement("SubTotIVASTI")]
        public double IVA { get { return Math.Round(_iva, 2); } set { _iva = value; } }
        public bool ShouldSerializeIVA() { return IVA != 0; }

        [XmlIgnore]
        private double _impuestoAdicional;
        /// <summary>
        /// Valor de los impuestos adicionales o específicos del subtotal.
        /// </summary>
        [XmlElement("SubTotAdicSTI")]
        public double ImpuestoAdicional { get { return Math.Round(_impuestoAdicional, 2); } set { _impuestoAdicional = value; } }
        public bool ShouldSerializeImpuestoAdicional() { return ImpuestoAdicional != 0; }

        [XmlIgnore]
        private double _montoExento;
        /// <summary>
        /// Valor no afecto o exento del subtotal.
        /// </summary>
        [XmlElement("SubTotExeSTI")]
        public double MontoExento { get { return Math.Round(_montoExento, 2); } set { _montoExento = value; } }
        public bool ShouldSerializeMontoExento() { return MontoExento != 0; }

        [XmlIgnore]
        private double _total;
        /// <summary>
        /// Valor de la línea de subtotal.
        /// </summary>
        [XmlElement("ValSubtotSTI")]
        public double Total { get { return Math.Round(_total, 2); } set { _total = value; } }
        public bool ShouldSerializeTotal() { return Total != 0; }

        /// <summary>
        /// tabla de líneas de detalle que se agrupan en el subtotal.
        /// </summary>
        [XmlElement("LineasDeta")]
        public List<int> LineasDetalle { get; set; }
        public bool ShouldSerializeLineasDetalle() { return LineasDetalle == null ? false : LineasDetalle.Count == 0 ? false : true; }

        public SubTotal()
        {
            NumeroSubTotal = 0;
            Glosa = string.Empty;
            Orden = 0;
            Neto = 0;
            IVA = 0;
            ImpuestoAdicional = 0;
            MontoExento = 0;
            Total = 0;
            LineasDetalle = null;
        }
    }
}
