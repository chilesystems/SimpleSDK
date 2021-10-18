using System;

namespace SimpleSDK.Models.LCV
{
    public class Caratula
    {
        /// <summary>
        /// Corresponde al rut del contribuyente emisor.
        /// Con guión y dígito verificador.
        /// </summary>
        public string RutEmisor { get; set; }

        /// <summary>
        /// Corresponde al rut del usuario autorizado que hace el envío al SII.
        /// </summary>
        public string RutEnvia { get; set; }

        /// <summary>
        /// Periodo tributario, en formato AAAA-MM.
        /// Si TipoLibro = 'Especial', y abarca más de un periodo, debe indicarse el primer periodo.
        /// Para la DJ 3328: debe indicarse el periodo del libro enviado. Se debe enviar un libro por cada periodo.
        /// </summary>
        public string PeriodoTributario { get; set; }

        /// <summary>
        /// Fecha resolución en fomarto AAAA-MM-DD.
        /// Para la DJ 3328: Debe ser valor fijo: 2016-01-20
        /// </summary>
        public DateTime FechaResolucion { get; set; }

        /// <summary>
        /// Número de resolución que autoriza al contribuyente como emisor electrónico.
        /// Para la DJ 3328: Debe ser valor fijo: 102006.
        /// </summary>
        public int NumeroResolucion { get; set; }

        /// <summary>
        /// Para IEV y F3328, valor fijo: VENTA.
        /// </summary>
        public Enum.TipoOperacionLibro.TipoOperacionLibroEnum TipoOperacion { get; set; }

        /// <summary>
        /// Mensual: Corresponde a los libros regulares.
        /// Especial: Corresponde a un libro solicitado vía una notificación.
        /// Rectifica: Corresponde a un libro que reemplaza a uno ya recibido por el SII. Requiere un código de autorización de reemplazo de libro electrónico en 'CodigoAutorizacionRectificacion'
        /// </summary>
        public Enum.TipoLibro.TipoLibroEnum TipoLibro { get; set; }

        /// <summary>
        /// Tipo de envío del libro.
        /// Si no se incluye, se asume TOTAL.
        /// </summary>
        public Enum.TipoEnvioLibro.TipoEnvioLibroEnum TipoEnvio { get; set; }

        /// <summary>
        /// Número del segmento.
        /// Sólo si TipoEnvio = 'PARCIAL'
        /// </summary>
        public int NumeroSegmento { get; set; }

        /// <summary>
        /// Folio de notificación. Obligatorio cuando el TipoEnvio = 'ESPECIAL'.
        /// Para la DJ3328: Debe ser valor fijo: 102006
        /// </summary>
        public int FolioNotificacion { get; set; }
        /// <summary>
        /// Código de autorización de reemplazo de libro electrónico: obtenido por un representante legal de la empresa, para permitir el reemplazo de un libro recibido OK por SII para un periodo y tipo de libro específico.
        /// Para la DJ 3328: No aplica.
        /// </summary>
        public string CodigoAutorizacionRectificacionLibro { get; set; }

        public Caratula()
        {
            TipoEnvio = Enum.TipoEnvioLibro.TipoEnvioLibroEnum.Total;
        }
    }
}