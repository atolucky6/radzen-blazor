using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RadzenBlazorDemos.Services
{
    public class FileService
    {
        public string GetText()
        {
            return File.ReadAllText("TextFile.txt");
        }
    }
}
