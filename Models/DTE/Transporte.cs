using System;
using System.Xml.Serialization;
using SimpleSDK.Helpers;

namespace SimpleSDK.Models.DTE
{
    /// <summary>
    /// Informacíón del Transporte.
    /// Esta información se debe registrar sólo si se dispone de la información al momento de confeccionar el documento electrónico. En caso contrario, bastará que vaya escrita en la representación impresa que acompaña el traslado de bienes.
    /// Relevante si Indicador Tipo de Despacho 2 (Emisor al cliente) o 3 (Emisor a otras instalaciones).
    /// </summary>
    public class Transporte
    {
        [XmlIgnore]
        public string _patente;
        /// <summary>
        /// Patente del vehículo que trasnporta los bienes.
        /// </summary>
        [XmlElement("Patente")]
        public string Patente { get { return _patente.Truncate(8); } set { _patente = value; } }
        public bool ShouldSerializePatente() { return !String.IsNullOrEmpty(Patente); }

        /// <summary>
        /// Rut del transportista.
        /// Con guión y dígito verificador.
        /// </summary>
        [XmlElement("RUTTrans")]
        public string RutTransportista { get; set; }
        public bool ShouldSerializeRutTransportista() { return !String.IsNullOrEmpty(RutTransportista); }

        /// <summary>
        /// Chofer
        /// </summary>
        [XmlElement("Chofer")]
        public Chofer Chofer { get; set; }
        public bool ShouldSerializeChofer() { return Chofer != null; }

        [XmlIgnore]
        private string _dirDestino;
        /// <summary>
        /// Dirección de destino.
        /// Datos correspondientes a la dirección de destino en documento que acompaña productos o a la dirección en que se otorga el servicio en caso de servicios periódicos.
        /// Aplica si el destino es distinto de Encabezado.Receptor.DirecciónReceptor o de Encabezado.Emisor.DirecciónEmisor en caso de Factura de compra.
        /// </summary>
        [XmlElement("DirDest")]
        public string DireccionDestino { get { return _dirDestino.Truncate(70); } set { _dirDestino = value; } }
        public bool ShouldSerializeDireccionDestino() { return !String.IsNullOrEmpty(DireccionDestino); }

        /// <summary>
        /// Comuna de destino.
        /// Análogo a dirección de destino.
        /// </summary>
        [XmlElement("CmnaDest")]
        public string ComunaDestino { get; set; }
        public bool ShouldSerializeComunaDestino() { return !String.IsNullOrEmpty(ComunaDestino); }

        /// <summary>
        /// Ciudad de destino.
        /// Análogo a dirección de destino,
        /// </summary>
        [XmlElement("CiudadDest")]
        public string CiudadDestino { get; set; }
        public bool ShouldSerializeCiudadDestino() { return !String.IsNullOrEmpty(CiudadDestino); }

        /// <summary>
        /// Documentos de exportación y guías de despacho.
        /// </summary>
        [XmlElement("Aduana")]
        public Aduana Aduana { get; set; }
        public bool ShouldSerializeAduana() { return Aduana != null; }

        public Transporte()
        {
        }
    }
}
