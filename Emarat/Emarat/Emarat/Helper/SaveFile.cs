using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Helper
{
    public class SaveFile
    {
        public static async Task<string> SaveFileAsync (IFormFile file , string path)
        {
            var FilePath = Directory.GetCurrentDirectory() + path;
            var FileName = Guid.NewGuid() + Path.GetFileName(file.FileName);
            var FinalPath = Path.Combine(FilePath, FileName);
            using (var Stream = new FileStream(FinalPath, FileMode.Create)) 
            {
                await file.CopyToAsync(Stream);
            }
            return FileName;
        }
    }
}
