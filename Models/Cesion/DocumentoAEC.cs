using System.Collections.Generic;

namespace SimpleSDK.Models.Cesion
{
    public class DocumentoAEC
    {
        /// <summary>
        /// Opcional. Si no viene, se autogenera
        /// </summary>
        public string ID { get; set; }
        public Caratula Caratula { get; set; }
        public List<Cesion> Cesiones { get; set; }
        public DocumentoAEC()
        {
            Caratula = new Caratula();
            Cesiones = new List<Cesion>();
        }
    }
}
