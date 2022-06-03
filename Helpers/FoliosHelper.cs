using System;
using System.Threading.Tasks;
using SimpleSDK.Models.Folios;

namespace SimpleSDK.Helpers
{
    public static class FoliosHelper
    {
        public static async Task<byte[]> ObtenerFolios(int tipo, int cantidad, FoliosData input)
        {
            throw new NotImplementedException();
        }
        
        public static async Task<int> ConsultarMaximoFoliosDisponibles(int tipo, FoliosData input)
        {
            throw new NotImplementedException();
        }
        
        public static async Task<(bool, string)> AnulacionMasiva(int tipo, int desde, int hasta, FoliosData input)
        {
            throw new NotImplementedException();
        }
        
        public static async Task<string> ResumenFolios(int tipo, DateTime desde, FoliosData input)
        {
            throw new NotImplementedException();
        }
    }
}