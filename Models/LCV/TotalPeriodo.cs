using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleSDK.Models.LCV
{
    public class TotalPeriodo
    {
        /// <summary>
        /// Para todos los tipos de documentos que se han informado en el archivo de detalle.
        /// Para todos los tipos de documentos que se han informado en el mes.
        /// Se debe agregar el resumen para los documentos correspondientes a Boletas y Resumen pasajes. 
        /// Códigos(35, 38, 39, 41, 105, 500, 501, 919, 920, 922 y 924)
        /// </summary>
        public Enum.TipoDTE.TipoDocumentoLibro TipoDocumento { get; set; }

        /// <summary>        
        /// Tipo de impuesto resumido (LC)
        /// Si se omite, se asume 1: IVA.
        /// </summary>
        public Enum.TipoImpuesto.TipoImpuestoResumido TipoImpuesto { get; set; }

        /// <summary>
        /// Número de Documentos del Tipo Incluidos en el Libro Electronico.
        /// Cantidad de documentos del tipo especificado en el campo Tipo de Documento. Incluye anulados.    
        /// Cantidad de documentos del tipo especificado en el campo 1. 
        /// Incluye anulados.
        /// Si tipo de documento es 35, 38, 39 y 41 se indica la cantidad de boletas emitidas en el mes.
        /// En el caso del documento 919 y 924 (Resumen Pasajes) se anota la cantidad de pasajes que se han vendido SIN FACTURA EXENTA.
        /// </summary>
        public int CantidadDocumentos { get; set; }

        /// <summary>
        /// Número de documentos anulados.
        /// Cantidad de documentos cuyos folios han sido anulados, previo al envío al SII. 
        /// Estos documentos no se totalizan en los campos siguientes.
        /// En el caso de los documentos manuales y de las Boletas Electrónicas , se registran todos los folios anulados.
        /// No se contabiliza aquí si un documento electrónico ha sido anulado, posterior al envío al SII, con Una Nota de Crédito o Debito.
        /// Esos documentos deben ser informados como emitidos, con todos los datos que correspondan.
        /// </summary>
        public int CantidadDocumentosAnulados { get; set; }

        /// <summary>
        /// Número de operaciones exentas.
        /// CAMPO PRÓXIMO A ELIMINARSE. Se mantiene para contribuyentes que están informándolo.
        /// Cantidad de documentos en que se ha registrado Montos del tipo especificado en el campo 3. 
        /// En el caso de facturas exentas, este monto es igual al del campo 2. 
        /// No se usa si tipo de documento es 35, 38, 39, 41, 105, 500, 501, 919, 920, 922 y 924.
        /// </summary>
        public int CantidadOperacionesExentas { get; set; }

        /// <summary>
        /// Total de los montos exentos.
        /// Si no hay montos de este tipo, se debe registrar un 0 
        /// </summary>
        public int TotalMontoExento { get; set; }

        /// <summary>
        /// Total de los montos netos.
        /// Si no hay montos de este tipo, se debe registrar un 0 
        /// </summary>
        public int TotalMontoNeto { get; set; }

        /// <summary>
        /// Total de operaciones con IVA Recuperable (LC). 
        /// ??
        /// </summary>
        public int CantidadOperacionesIVaRecuperable { get; set; }

        /// <summary>
        /// Total de los montos de IVA (LV) o IVA Recuperable (LC).
        /// Si no hay montos de este tipo, se debe registrar un 0.
        /// </summary>
        public int TotalMontoIva { get; set; }

        /// <summary>
        /// Cantidad de operaciones de Activo Fijo (LC).
        /// </summary>
        public int CantidadOperacionesActivoFijo { get; set; }

        /// <summary>
        /// Total monto neto de las operaciones de Activo Fijo.
        /// </summary>
        public int TotalMontoNetoOperacionesActivoFijo { get; set; }

        /// <summary>
        /// Total del IVA de las operaciones de Activo Fijo.
        /// </summary>
        public int TotalMontoIVAOperacionesActivoFijo { get; set; }

        /// <summary>
        /// Totales de IVA No Recuperable (LC).
        /// Hasta 5 repeticiones.
        /// </summary>
        public List<TotalIVANoRecuperable> TotalIVANoRecuperable { get; set; }

        /// <summary>
        /// Número de operaciones conIVA Uso Común (LC)
        /// </summary>
        public int CantidadOperacionesConIvaUsoComun { get; set; }

        /// <summary>
        /// Total IVA Uso Común (LC)
        /// </summary>
        public int TotalIVAUsoComun { get; set; }

        /// <summary>
        /// Factor de proporcionalidad de IVA (LC)
        /// </summary>
        public double FactorProporcionalidadIVA { get; set; }

        /// <summary>
        /// Total crédito IVA Uso Común. (LC).
        /// </summary>
        public int TotalCreditoIVAUsoComun { get; set; }

        /// <summary>
        /// Total IVa Fuera de Plazo.
        /// Sólo en Notas de Crédito.
        /// </summary>
        public int TotalIVAFueraPlazo { get; set; }

        /// <summary>
        /// Total IVA Propio en operaciones a cuenta de terceros (LV).
        /// Sólo cuando hay venta o servicio por cuenta de terceros.
        /// </summary>
        public int TotalIVAPropio { get; set; }

        /// <summary>
        /// Total de IVA a cuenta de terceros. (LV).
        ///  Sólo cuando hay venta o servicio por cuenta de terceros.
        /// </summary>
        public int TotalIVATerceros { get; set; }

        /// <summary>
        /// Total Ley 18.211 (LV).
        /// Impuesto Zona Franca.
        /// </summary>
        public int TotalLey18211 { get; set; }

        /// <summary>
        /// Totales otros impuestos.
        /// </summary>
        public List<ImpuestosPeriodo> Impuestos { get; set; }

        /// <summary>
        /// Total de impuestos sin derecho a crédito (LC).
        /// </summary>
        public int TotalImpuestosSinDerechoACredito { get; set; }

        /// <summary>
        /// Número de operaciones con IVA Retenido Total (LV).
        /// CAMPO PRÓXIMO A ELIMINARSE. Se mantiene para contribuyentes que están informándolo.
        /// Cantidad de documentos en que se ha registrado Montos del tipo especificado en el campo siguiente.
        /// Sólo aplica para Factura de Compra recibidas
        /// </summary>
        public int CantidadOperacionesConIVARetenidoTotal { get; set; }

        /// <summary>
        /// Total de IVA Retenido Total (LV).
        /// </summary>
        public int TotalIVARetenidoTotal { get; set; }

        /// <summary>
        /// Número de operaciones con IVA Retenido Parcial (LV).
        /// CAMPO PRÓXIMO A ELIMINARSE. Se mantiene para contribuyentes que están informándolo.
        /// Cantidad de documentos en que se ha registrado Montos del tipo especificado en el campo siguiente.
        /// Sólo aplica para Factura de Compra recibidas
        /// </summary>
        public int CantidadOperacionesConIVARetenidoParcial { get; set; }

        /// <summary>
        /// Total de IVA Retenido Parcial (LV).
        /// </summary>
        public int TotalIVARetenidoParcial { get; set; }

        /// <summary>
        /// Total crédito empresa constructora.
        /// </summary>
        public int TotalCreditoEmpresaContructora { get; set; }

        /// <summary>
        /// Total de los depósitos por Envase (LV).
        /// </summary>
        public int TotalDepositoEnvase { get; set; }

        /// <summary>
        /// Info. Elect. de Venta (LV).
        /// Totaliza por código para cada tipo de documento
        /// </summary>
        public List<TotalLiquidacion> TotalLiquidacion { get; set; }

        /// <summary>
        /// Total de los montos totales.
        /// Totales de los documentos.
        /// </summary>
        public int TotalMonto { get; set; }

        /// <summary>
        /// Número de operaciones con IVA No Retenido (LV).
        /// CAMPO PRÓXIMO A ELIMINARSE. Se mantiene para contribuyentes que están informándolo.
        /// Cantidad de documentos en que se ha registrado Montos del tipo especificado en el campo siguiente.
        /// Sólo aplica para Factura de Compra recibidas        
        /// </summary>
        public int CantidadOperacionesConIvaNoRetenido { get; set; }

        /// <summary>
        /// Total IVA No Retenido
        /// </summary>
        public int TotalMontoIvaNoRetenido { get; set; }

        /// <summary>
        /// Total monto No Facturable (LV).
        /// Valor puede ser negativo.
        /// </summary>
        public int TotalMontoNoFacturable { get; set; }

        /// <summary>
        /// Total monto periodo (LV).
        /// Valor puede ser negativo
        /// </summary>
        public int TotalMontoPeriodo { get; set; }

        /// <summary>
        /// Total venta pasaje Nacional (LV).
        /// Sólo ventas con Factura Exenta.
        /// </summary>
        public int TotalPasajeNacional { get; set; }

        /// <summary>
        /// Total venta pasaje internacional (LV).
        /// Sólo ventas con Factura Exenta.
        /// </summary>
        public int TotalPasajeInternacional { get; set; }

        /// <summary>
        /// Total Tabacos - Puros (LC).
        /// </summary>
        public int TotalTabacos_Puros { get; set; }

        /// <summary>
        /// Total Tabacos - Cigarrillos
        /// </summary>
        public int TotalTabacos_Cigarrillos { get; set; }

        /// <summary>
        /// Total Tabacos - Elaborados
        /// </summary>
        public int TotalTabacos_Elaborados { get; set; }

        /// <summary>
        /// Total impuesto vehiculos (LC).
        /// </summary>
        public int TotalImpuestoVehiculo { get; set; }
    }
}