using SimpleSDK.Models.Extras;
using System;
using System.Collections.Generic;

namespace SimpleSDK.Models.LCV
{
    public class LibroGuia : Envios.EnvioSII
    {
        /// <summary>
        /// Debe ser un NCName
        /// Debe empezar con letra o guión bajo.
        /// Puede contener sólo dígitos, letras, guiones bajo, guiones y puntos.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Contiene datos generales de la información del envío los cuales corresponden al Rut del contribuyente emisor, período tributario, tipo de segmento,
        /// y número de Segmento en el caso de envíos parciales.
        /// </summary>
        public Caratula Caratula { get; set; }

        /// <summary>
        /// Contiene los totales por tipo de documento. Esta Zona es obligatoria si viene la Zona de Detalle, excepto si el envío es TOTAL.
        /// Las boletas u otros que se incluyen sólo totalizados, no se incluyen en este resumen y deben ir sólo en el Resumen Período.
        /// </summary>
        public ResumenSegmento ResumenSegmentoLibro { get; set; }

        /// <summary>
        /// En este resumen se deben entregar totalizados los montos por campo de cada tipo de documento de todo el período. 
        /// También es obligatorio en el caso de efectuar ajustes posteriores al cierre del período.        
        /// 
        /// Resumen para el periodo tributario.
        /// 
        /// En cuanto a contenido:
        ///  - El resumen del período se debe construir en base a todos los Resúmenes de Segmento del período enviados.
        ///  - En consecuencia, no se debe enviar hasta que exista la seguridad que no hay rechazos a los segmentos.
        ///  - Aparte de totalizar lo que se informó en los segmentos, se debe agregar la información de los documentos que sólo se registran como totales (boletas u otros), incorporando una línea por tipo de documento.
        ///  - En el IEC se deben agregar los campos para determinar el crédito en base a proporcionalidad.
        /// En cuanto al tipo de envío
        ///  - El Resumen Periodo se debe incluir en un envío de tipo TOTAL, FINAL o AJUSTE.
        ///  - Si el envío es FINAL este debe incluir sólo el Resumen Período.
        ///  - Si el envío es TOTAL, el Resumen Período puede venir acompañado de Detalle (si hay documentos que informar).
        ///  - Si el envío es AJUSTE, el Resumen Período puede venir acompañado de Detalle y de Resumen Segmento(si hay documentos que informar). 
        /// </summary>
        public ResumenPeriodo ResumenPeriodo { get; set; }

        /// <summary>
        /// Detalle de documentos que componen el libro electrónico.
        /// En esta Zona se debe detallar una línea por cada documento. No se incluyen documentos del tipo totales, tales como Boletas o Resumen de pasajes.
        /// El detalle se incluye en un envío sólo si hay documentos, informados uno a uno.
        /// </summary>
        public List<Detalle> Detalles { get; set; }

        /// <summary>
        /// Exclusico para Libro Contable Electrónico
        /// No aplica para DJ: 3327 Y 3328.
        /// El Certificado de Autorización de Libros (CAL) es otorgado por el SII al Rut que ha efectuado las pruebas.
        /// A través de la entrega del CAL, el SII confirma que ese contribuyente es capaz de generar el respectivo Libro Contable Electrónico.
        /// </summary>
        public CertificadoAutorizacionLibro CertificadoAutorizacionLibro { get; set; }

        /// <summary>
        /// Exclusivo para Libro Contable Electrónico
        /// </summary>
        public ComprobanteCertificado ComprobanteCertificado { get; set; }
    }
}
