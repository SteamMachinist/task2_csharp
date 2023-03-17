using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_csharp
{
    internal class FileHandler
    {
        public static string readFile(string path) 
        { 
            return File.ReadAllText(path); 
        }

        public static void writeFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }
    }
}
