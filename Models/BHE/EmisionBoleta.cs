using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Models.BHE
{
    public class EmisionBoleta
    {
        public long Folio { get; set; }
        public string CodigoBarras { get; set; }
        public DateTime FechaEmision { get; set; }
        public string PdfBase64 { get; set; }
    }
}
