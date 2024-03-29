﻿using SimpleSDK.Enum;
using SimpleSDK.Models.Extras;
using System;
using System.Xml.Serialization;

namespace SimpleSDK.Models.DTE
{
    [XmlRoot("DTE", Namespace = "")]
    public class DTE
    {
        [XmlAttribute("version")]
        public string Version { get { return "1.0"; } set { } }

        [XmlElement("Documento")]
        public Documento Documento { get; set; }
        public bool ShouldSerializeDocumento() { return Documento != null && !string.IsNullOrEmpty(Documento.Id); }

        [XmlElement("Exportaciones")]
        public Exportaciones Exportaciones { get; set; }
        public bool ShouldSerializeExportaciones() { return Exportaciones != null && !string.IsNullOrEmpty(Exportaciones.Id); }


        /// <summary>
        /// Corresponde a los datos del certificado digital. Se debe indicar la ruta del archivo pfx y su contraseña.
        /// </summary>
        public CertificadoDigital Certificado { get; set; }

        public DTE(Emisor emisor, Receptor receptor, long folio, TipoDTE.DTEType tipo)
        {
            Documento = new Documento();
            Certificado = new CertificadoDigital();

            Documento.Encabezado.Emisor = emisor;
            Documento.Encabezado.Receptor = receptor;

            Documento.Encabezado.IdentificacionDTE.Folio = folio;
            Documento.Encabezado.IdentificacionDTE.TipoDTE = tipo;
            Documento.Encabezado.IdentificacionDTE.FechaEmision = DateTime.Now;
            
            //Para boletas electrónicas
            if (tipo == TipoDTE.DTEType.BoletaElectronica || tipo == TipoDTE.DTEType.BoletaElectronicaExenta)
            {
                Documento.Encabezado.IdentificacionDTE.IndicadorServicio = IndicadorServicio.IndicadorServicioEnum.BoletaVentasYServicios;
            }
        }

        public DTE(Emisor emisor, Receptor receptor, long folio, TipoDTE.DTEType tipo, Aduana aduana, OtraMoneda otraMoneda)
        {
            Exportaciones = new Exportaciones();
            Exportaciones.Encabezado.Transporte = new Transporte();
            Exportaciones.Encabezado.Transporte.Aduana = aduana;
            Exportaciones.Encabezado.OtraMoneda = otraMoneda;

            Certificado = new CertificadoDigital();

            Exportaciones.Encabezado.Emisor = emisor;
            Exportaciones.Encabezado.Receptor = receptor;

            Exportaciones.Encabezado.IdentificacionDTE.Folio = folio;
            Exportaciones.Encabezado.IdentificacionDTE.TipoDTE = tipo;
            Exportaciones.Encabezado.IdentificacionDTE.FechaEmision = DateTime.Now;


        }


        public DTE()
        {
            Certificado = new CertificadoDigital();
            Documento = new Documento();
        }

       
    }
}
