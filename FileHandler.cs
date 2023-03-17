using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_csharp
{
    internal class FileHandler
    {
        public string readFile(string filename) 
        { 
            return File.ReadAllText(preparePath(filename)); 
        }

        public void writeFile(string filename, string content)
        {
            File.WriteAllText(filename + "_processed", content);
        }

        private string preparePath(string filename) 
        {
            string relation = @"..\..\..\texts\";
            string path = Path.Combine(Environment.CurrentDirectory, relation, filename + ".txt");
            return path;
        }
    }
}
