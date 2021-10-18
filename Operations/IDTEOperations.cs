using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSDK.Operations
{
    public interface IDTEOperations
    {
        Task<string> Generate(Models.DTE.DTE dte, string pathCAF, string apikey);
    }
}
