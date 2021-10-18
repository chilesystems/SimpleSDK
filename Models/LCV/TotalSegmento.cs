using System.Collections.Generic;

namespace SimpleSDK.Models.LCV
{
    public class TotalSegmento
    {
        /// <summary>
        /// Para todos los tipos de documentos que se han informado en el archivo de detalle
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
        /// </summary>
        public int CantidadDocumentos { get; set; }

        /// <summary>
        /// Número de documentos anulados.
        /// Ventas:
        /// Cantidad de documentos cuyos folios han sido anulados, previo al envío al SII. Estos documentos no se totalizan en los campos siguientes.
        /// No se contabiliza aquí si un documento electrónico ha sido anulado posterior al envío al SII, con Una Nota de Crédito o Debito.
        /// Esos documentos deben ser informados como emitidos, con todos los datos que correspondan. 
        /// 
        /// Compras:
        /// 
        /// Sólo Facturas de Compra emitidas, Notas de Crédito y Débito relacionadas a Factura de Compra emitidas
        /// Cantidad de Documentos Electrónicos señalados cuyos folios han sido anulados, previo al envío al SII.
        /// Estos documentos no se totalizan en los campos siguientes.
        /// En el caso de los documentos manuales se registran todos los folios anulados.
        /// No se contabiliza aquí si una Factura de Compra electrónica ha sido anulada, posterior al envío al SII, con una Nota de Crédito.Esos documentos deben ser informados como emitidos, con todos los datos que correspondan.
        /// </summary>
        public int CantidadDocumentosAnulados { get; set; }

        /// <summary>
        /// Número de operaciones exentas
        /// CAMPO PRÓXIMO A ELIMINARSE. Se mantiene para contribuyentes que están informándolo
        /// Cantidad de documentos en que se ha registrado Montos del tipo especificado en el campo 3. 
        /// En el caso de facturas exentas, este monto es igual al del campo 2. 
        /// </summary>
        public int CantidadOperacionesExentas { get; set; }

        /// <summary>
        /// Total de los montos exentos.
        /// Si no hay montos de este tipo, se debe registrar un cero.
        /// </summary>
        public int TotalMontoExento { get; set; }

        /// <summary>
        /// Total de los montos netos.
        /// Si no hay montos de este tipo, se debe registrar un cero.
        /// </summary>
        public int TotalMontoNeto { get; set; }

        /// <summary>
        /// Total de operaciones con IVA Recuperable (LC)
        /// </summary>
        public int CantidadOperacionesIVaRecuperable { get; set; }

        /// <summary>
        /// Total de los montos de IVA (LV) o IVA Recuperable (LC).
        /// Si no hay montos de este tipo, se debe registrar un cero.
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
        /// Total IVa Fuera de Plazo.
        /// Sólo aplica para Notas de Crédito.
        /// </summary>
        public int TotalIVAFueraPlazo { get; set; }

        /// <summary>
        /// Total IVA Propio en operaciones a cuenta de terceros (LV)..
        /// Sólo cuando hay venta o servicio por cuenta de terceros.
        /// </summary>
        public int TotalIVAPropio { get; set; }

        /// <summary>
        /// Total de IVA a cuenta de terceros. (LV).
        /// Sólo cuando hay venta o servicio por cuenta de terceros 
        /// </summary>
        public int TotalIVATerceros { get; set; }

        /// <summary>
        /// Total Ley 18.211 (LV).
        /// </summary>
        public int TotalLey18211 { get; set; }

        /// <summary>
        /// Totales otros impuestos.
        /// Hasta 20 posibles ocurrencias.
        /// Totaliza por código para cada tipo de documento
        /// </summary>
        public List<ImpuestosSegmento> Impuestos { get; set; }

        /// <summary>
        /// Total de impuestos sin derecho a crédito (LC).
        /// </summary>
        public int TotalImpuestosSinDerechoACredito { get; set; }

        /// <summary>
        /// Número de operaciones con IVA Retenido Total (LV).
        ///  Cantidad de documentos en que se ha registrado Montos del tipo especificado en TotalIVARetenidoTotal.        
        /// </summary>
        public int CantidadOperacionesConIVARetenidoTotal { get; set; }

        /// <summary>
        /// Total de IVA Retenido Total (LV).
        /// Totales por documento
        /// </summary>
        public int TotalIVARetenidoTotal { get; set; }

        /// <summary>
        /// Número de operaciones con IVA Retenido Parcial (LV).
        /// Cantidad de documentos en que se ha registrado Montos del tipo especificado en TotalIVARetenidoParcial.

        /// </summary>
        public int CantidadOperacionesConIVARetenidoParcial { get; set; }

        /// <summary>
        /// Total de IVA Retenido Parcial (LV).
        /// Totales por documento
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
        /// Hasta 20 posibles ocurrencias.
        /// Totaliza por código para cada tipo de documento
        /// </summary>
        public List<TotalLiquidacion> TotalLiquidacion { get; set; }

        /// <summary>
        /// Total de los montos totales.
        /// Suma para el tipo de documento
        /// </summary>
        public int TotalMonto { get; set; }

        /// <summary>
        /// Número de operaciones con IVA No Retenido (LV).
        /// Cantidad de documentos en que se ha registrado Montos del tipo especificado en TotalMontoIvaNoRetenido.
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
        /// Valor puede ser negativo.
        /// </summary>
        public int TotalMontoPeriodo { get; set; }

        /// <summary>
        /// Total venta pasaje Nacional (LV).
        /// Sólo ventas con Factura Exenta.
        /// </summary>
        public int TotalPasajeNacional { get; set; }

        /// <summary>
        /// Total venta pasaje internacional (LV).
        ///  Sólo ventas con Factura Exenta.
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
    }
}