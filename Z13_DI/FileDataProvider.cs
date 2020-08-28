using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13_DI
{
    public class FileDataProvider : IDataProvider
    {
        public int GetData()
        {
            var content = File.ReadAllText("C:/Users/Intel/Desktop/Programowanie projekt/Z13_DI/plik.txt");
            var lines = content.Split(new[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            return Convert.ToInt32(lines[0]);
        }
    }
}
