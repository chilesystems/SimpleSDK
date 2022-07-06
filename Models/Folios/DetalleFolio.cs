using CsvHelper.Configuration.Attributes;

namespace SimpleSDK.Models.Folios
{
    public class DetalleFolio
    {
        [Index(0)]
        public long FolioInicial { get; set; }
        [Index(1)]
        public long FolioFinal { get; set; }
        [Index(2)]
        public int NumeroFolios { get; set; }
    }
}
