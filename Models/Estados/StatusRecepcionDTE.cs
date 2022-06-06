using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSDK.Models.Estados
{
    public class StatusRecepcionResult
    {
        public bool isRecibido { get; set; }
        public bool? isAceptado { get; set; }
        public bool? isRechazado { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaEvento { get; set; }
    }
}
