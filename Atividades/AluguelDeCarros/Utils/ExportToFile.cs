using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlTypes;

namespace AluguelDeCarros.Utils
{
    public class ExportToFile
    {
        private const string dir = @"D:\Unoesc\Programacao1\Prog1_24\Atividades\AluguelDeCarros\Arquivo";

        public static bool SaveToDelimitedTxt(string fileName, string fileContent) {
            string filePath = $@"{dir}\{fileName}";

            try {
                if (!System.IO.Directory.Exists(dir)) {
                    Directory.CreateDirectory(dir);
                }
                using(StreamWriter sw = File.CreateText(filePath)) {
                    sw.Write(fileContent);
                }
            }

            catch {
                return false;
            }

            return true;
        }
    }
}