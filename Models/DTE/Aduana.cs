using SimpleSDK.Helpers;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    public class Aduana
    {
        /// <summary>
        /// Código según tabla "Modalidad de Venta" de aduana.
        /// Se refiere a si la exportación se realiza bajo venta, En consignación, a firme, en Consignación con mínimo a firme, etc.)
        /// Campo Obligatorio para Factura de Exportación, excepto cuando en el Campo “Indicador Servicio” se indicó 3 (Factura de servicios), 4 (Servicios Hotelería) o 5 (Transporte Terrestre Internacional). 
        /// </summary>
        [XmlElement("CodModVenta")]
        public Enum.CodigosAduana.ModalidadVenta CodigoModalidadVenta { get; set; }
        public bool ShouldSerializeCodigoModalidadVenta() { return CodigoModalidadVenta != Enum.CodigosAduana.ModalidadVenta.NotSet; }

        /// <summary>
        /// Código según Tabla "Cláusula compra-venta" de aduana.
        /// Se refiere a la cláusula de venta indicada en el DUS ( FOB, CIF, etc.).
        /// Campo Obligatorio, excepto cuando en el Campo “Indicador Servicio” se indicó 3 (Factura de servicios), 4 (Servicios Hotelería) o 5 (Transporte Terrestre Internacional). 
        /// </summary>
        [XmlElement("CodClauVenta")]
        public Enum.CodigosAduana.ClausulaCompraVenta CodigoClausulaVenta { get; set; }
        public bool ShouldSerializeCodigoClausulaVenta() { return CodigoClausulaVenta != Enum.CodigosAduana.ClausulaCompraVenta.NotSet; }

        [XmlIgnore]
        private double _totalClausulaVenta { get; set; }

        /// <summary>
        /// Total cláusula de venta.
        /// Corresponde al valor total de la exportación a pagar por el importador según la cláusula de venta acordada entre las partes y que se indica en el DUS. (No incluye comisiones ni otros gastos deducibles en el exterior).
        /// Campo Obligatorio, excepto cuando en el Campo “Indicador Servicio” se indicó 3 (Factura de servicios), 4 (Servicios Hotelería) o 5 (Transporte Terrestre Internacional). 
        /// </summary>
        [XmlElement("TotClauVenta")]
        public double TotalClausulaVenta { get { return Math.Round(_totalClausulaVenta, 2); } set { _totalClausulaVenta = value; } }
        public bool ShouldSerializeTotalClausulaVenta() { return TotalClausulaVenta != 0; }

        /// <summary>
        /// Indicar el código de la vía de transporte utilizada para trasnportar la mercadería, según tabla "Vías de transporte" de aduana.
        /// Corresponde a la vía de transporte por donde se envía la mercadería (aéreo, terrestre, marítimo, etc) al extranjero.
        /// Campo obligatorio, a excepción cuando en el “Indicador Servicio” se registra la opción N° 4 (Servicios de hotelería)
        /// </summary>
        [XmlElement("CodViaTransp")]
        public Enum.CodigosAduana.ViasdeTransporte CodigoViaTransporte { get; set; }
        public bool ShouldSerializeCodigoViaTransporte() { return CodigoViaTransporte != Enum.CodigosAduana.ViasdeTransporte.NotSet; }

        [XmlIgnore]
        private string _nombreTransporte;
        /// <summary>
        /// Nombre o identificación del medio de transporte.
        /// Corresponde al nombre o glosa de la nave transportista. 
        /// </summary>
        [XmlElement("NombreTransp")]
        public string NombreTransporte { get { return _nombreTransporte.Truncate(40); } set { _nombreTransporte = value; } }
        public bool ShouldSerializeNombreTransporte() { return !String.IsNullOrEmpty(NombreTransporte); }

        /// <summary>
        /// Rut compañía transportadora.
        /// Para doctos. utilizados en exportación. 
        /// Señale el Rol Unico Tributario (RUT) de la compañía transportista indicada en el DUS. Si ésta es extranjera, señale el RUT de la Agencia que la representa en Chile.
        /// </summary>
        [XmlElement("RUTCiaTransp")]
        public string RutCompañiaTransporte { get; set; }
        public bool ShouldSerializeRutCompañiaTransporte() { return !String.IsNullOrEmpty(RutCompañiaTransporte); }

        [XmlIgnore]
        private string _nombreCiaTransporte;
        /// <summary>
        /// Nombre compañía transportadora
        /// Nombre de la Cía. transportadora declarada en el DUS.
        /// </summary>
        [XmlElement("NomCiaTransp")]
        public string NombreCompañiaTransporte { get { return _nombreCiaTransporte.Truncate(40); } set { _nombreCiaTransporte = value; } }
        public bool ShouldSerializeNombreCompañiaTransporte() { return !String.IsNullOrEmpty(NombreCompañiaTransporte); }

        [XmlIgnore]
        private string _idAdicionalCiaTransporte;
        /// <summary>
        /// Identificador adicional de la compañía transportadora.
        /// Identificación adicional para uso libre.
        /// </summary>
        [XmlElement("IdAdicTransp")]
        public string IdentificadorAdicionalCompañiaTransporte { get { return _idAdicionalCiaTransporte.Truncate(20); } set { _idAdicionalCiaTransporte = value; } }
        public bool ShouldSerializeIdentificadorAdicionalCompañiaTransporte() { return !String.IsNullOrEmpty(IdentificadorAdicionalCompañiaTransporte); }

        [XmlIgnore]
        private string _booking;
        /// <summary>
        /// Número de reserva del operador.
        /// Número de Booking o Reserva del operador.
        /// </summary>
        [XmlElement("Booking")]
        public string NumeroReservaOperador { get { return _booking.Truncate(20); } set { _booking = value; } }
        public bool ShouldSerializeNumeroReservaOperador() { return !String.IsNullOrEmpty(NumeroReservaOperador); }

        [XmlIgnore]
        private string _codigoOperador;
        /// <summary>
        /// Código del operador.
        /// </summary>
        [XmlElement("Operador")]
        public string CodigoOperador { get { return _codigoOperador.Truncate(20); } set { _codigoOperador = value; } }
        public bool ShouldSerializeCodigoOperador() { return !String.IsNullOrEmpty(CodigoOperador); }

        /// <summary>
        /// Código del puerto de embarque de mercacías, según tabla de Aduana.
        /// En Guías: obligatorio sólo para Indicador tipo traslado = 8 (Traslado para exportación) y 9 (Venta para exportación).
        /// En Facturas de Exportación: Obligatorio excepto cuando el “Indicador Servicio” = 4 (Servicios de hotelería).
        /// </summary>
        [XmlElement("CodPtoEmbarque")]
        public Enum.CodigosAduana.Puertos CodigoPuertoEmbarque { get; set; }
        public bool ShouldSerializeCodigoPuertoEmbarque() { return CodigoPuertoEmbarque != Enum.CodigosAduana.Puertos.NotSet; }

        [XmlIgnore]
        private string _idAdicionalPtoEmbarque;
        /// <summary>
        /// Identificador adicional del puerto de embarque.
        /// Identificación adicional para uso libre.
        /// </summary>
        [XmlElement("IdAdicPtoEmb")]
        public string IdentificadorAdicionalPuertoEmbarque { get { return _idAdicionalPtoEmbarque.Truncate(20); } set { _idAdicionalPtoEmbarque = value; } }
        public bool ShouldSerializeIdentificadorAdicionalPuertoEmbarque() { return !String.IsNullOrEmpty(IdentificadorAdicionalPuertoEmbarque); }

        /// <summary>
        /// Código del puerto de desembarque según tabla de Aduana.
        /// En Guías: obligatorio sólo para Indicador tipo traslado = 8 (Traslado para exportación) y 9 (Venta para exportación).
        /// En Facturas de Exportación: Obligatorio excepto cuando el “Indicador Servicio” = 4 (Servicios de hotelería).
        /// </summary>
        [XmlElement("CodPtoDesemb")]
        public Enum.CodigosAduana.Puertos CodigoPuertoDesembarque { get; set; }
        public bool ShouldSerializeCodigoPuertoDesembarque() { return CodigoPuertoDesembarque != Enum.CodigosAduana.Puertos.NotSet; }

        [XmlIgnore]
        private string _idAdicionalPtoDesembarque;
        /// <summary>
        /// Identificador adicional del puerto de desembarque.
        /// Identificación adicional para uso libre.
        /// </summary>
        [XmlElement("IdAdicPtoDesemb")]
        public string IdentificadorAdicionalPuertoDesembarque { get { return _idAdicionalPtoDesembarque.Truncate(20); } set { _idAdicionalPtoDesembarque = value; } }
        public bool ShouldSerializeIdentificadorAdicionalPuertoDesembarque() { return !String.IsNullOrEmpty(IdentificadorAdicionalPuertoDesembarque); }

        /// <summary>
        /// Tara
        /// </summary>
        [XmlElement("Tara")]
        public int Tara { get; set; }
        public bool ShouldSerializeTara() { return Tara != 0; }

        /// <summary>
        /// Código de la unidad de medida según tabla de Aduana.
        /// Indique la unidad de medida en la que se encuentra expresado la Tara.
        /// </summary>
        [XmlElement("CodUnidMedTara")]
        public Enum.CodigosAduana.UnidadMedida CodigoUnidadMedidaTara { get; set; }
        public bool ShouldSerializeCodigoUnidadMedidaTara() { return CodigoUnidadMedidaTara != Enum.CodigosAduana.UnidadMedida.NotSet; }

        [XmlIgnore]
        private double _pesoBruto;

        /// <summary>
        /// Sumatoria de los pesos brutos de todos los ítems del documento.
        /// En Guías: obligatorio sólo para Indicador tipo traslado = 8 (Traslado para exportación) y 9 (Venta para exportación).
        /// </summary>
        [XmlElement("PesoBruto")]
        public double PesoBruto { get { return Math.Round(_pesoBruto, 2); } set { _pesoBruto = value; } }
        public bool ShouldSerializePesoBruto() { return PesoBruto != 0; }

        /// <summary>
        /// Indique la unidad de medida en la que se encuentra expresado el peso bruto de la mercadería, según tabla de Aduana.
        /// En Guías: obligatorio sólo para Indicador tipo traslado = 8 (Traslado para exportación) y 9 (Venta para exportación).
        /// </summary>
        [XmlElement("CodUnidPesoBruto")]
        public Enum.CodigosAduana.UnidadMedida CodigoUnidadPesoBruto { get; set; }
        public bool ShouldSerializeCodigoUnidadPesoBruto() { return CodigoUnidadPesoBruto != Enum.CodigosAduana.UnidadMedida.NotSet; }

        [XmlIgnore]
        private double _pesoNeto;

        /// <summary>
        /// Sumatoria de los pesos netos de todos los ítems del documento.
        /// </summary>
        [XmlElement("PesoNeto")]
        public double PesoNeto { get { return Math.Round(_pesoNeto, 2); } set { _pesoNeto = value; } }
        public bool ShouldSerializePesoNeto() { return PesoNeto != 0; }

        /// <summary>
        /// Indique la unidad de medida en la que se encuentra expresado el peso neto de la mercadería, según tabla de Aduana.
        /// </summary>
        [XmlElement("CodUnidPesoNeto")]
        public Enum.CodigosAduana.UnidadMedida CodigoUnidadPesoNeto { get; set; }
        public bool ShouldSerializeCodigoUnidadPesoNeto() { return CodigoUnidadPesoNeto != Enum.CodigosAduana.UnidadMedida.NotSet; }

        /// <summary>
        /// Indique el total de items del documento
        /// </summary>
        [XmlElement("TotItems")]
        public int TotalItems { get; set; }
        public bool ShouldSerializeTotalItems() { return TotalItems != 0; }

        /// <summary>
        /// Cantidad de bultos que ampara el documento.
        /// En Guías: obligatorio sólo para Indicador tipo traslado = 8 (Traslado para exportación) y 9 (Venta para exportación).
        /// </summary>
        [XmlElement("TotBultos")]
        public int CantidadBultos { get; set; }
        public bool ShouldSerializeCantidadBultos() { return CantidadBultos != 0; }

        /// <summary>
        /// Tabla de descripción de los distintos tipos de bultos.
        /// </summary>
        [XmlElement("TipoBultos")]
        public List<TipoBulto> TipoBultos { get; set; }
        public bool ShouldSerializeTipoBultos() { return TipoBultos == null ? false : TipoBultos.Count == 0 ? false : true; }

        [XmlIgnore]
        private double _montoFlete;

        /// <summary>
        /// Montos del flete, según moneda de venta.
        /// </summary>
        [XmlElement("MntFlete")]
        public double MontoFlete { get { return Math.Round(_montoFlete, 4); } set { _montoFlete = value; } }
        public bool ShouldSerializeMontoFlete() { return MontoFlete != 0; }

        [XmlIgnore]
        private double _montoSeguro;

        /// <summary>
        /// Monto del seguro, según moneda de venta.
        /// </summary>
        [XmlElement("MntSeguro")]
        public double MontoSeguro { get { return Math.Round(_montoSeguro, 4); } set { _montoSeguro = value; } }
        public bool ShouldSerializeMontoSeguro() { return MontoSeguro != 0; }

        /// <summary>
        /// Código del país del receptor extranjero de la mercadería, según tabla de países de Aduana.
        /// Análogo a Dirección Receptor.
        /// </summary>
        [XmlElement("CodPaisRecep")]
        public Enum.CodigosAduana.Paises CodigoPaisReceptor { get; set; }
        public bool ShouldSerializeCodigoPaisReceptor() { return CodigoPaisReceptor != Enum.CodigosAduana.Paises.NotSet; }

        /// <summary>
        /// Código del país de destino extranjero de la mercadería, según tabla de países de Aduana.
        /// Análogo Dirección Destino.
        /// </summary>
        [XmlElement("CodPaisDestin")]
        public Enum.CodigosAduana.Paises CodigoPaisDestino { get; set; }
        public bool ShouldSerializeCodigoPaisDestino() { return CodigoPaisDestino != Enum.CodigosAduana.Paises.NotSet; }

        public Aduana()
        {
            CodigoModalidadVenta = 0;
            CodigoClausulaVenta = 0;
            TotalClausulaVenta = 0;
            CodigoViaTransporte = 0;
            NombreTransporte = string.Empty;
            RutCompañiaTransporte = string.Empty;
            IdentificadorAdicionalCompañiaTransporte = string.Empty;
            NumeroReservaOperador = string.Empty;
            CodigoOperador = string.Empty;
            CodigoPuertoEmbarque = 0;
            IdentificadorAdicionalPuertoEmbarque = string.Empty;
            CodigoPuertoDesembarque = 0;
            IdentificadorAdicionalPuertoDesembarque = string.Empty;
            Tara = 0;
            CodigoUnidadMedidaTara = 0;
            PesoBruto = 0;
            CodigoUnidadPesoBruto = 0;
            PesoNeto = 0;
            CodigoUnidadPesoNeto = 0;
            TotalItems = 0;
            CantidadBultos = 0;
            TipoBultos = new List<TipoBulto>();
            MontoFlete = 0;
            MontoSeguro = 0;
            CodigoPaisReceptor = 0;
            CodigoPaisDestino = 0;
        }
    }
}
