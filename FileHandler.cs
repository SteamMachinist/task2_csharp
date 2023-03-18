using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_csharp
{
    internal class FileHandler
    {
        public StreamReader streamReaderFile(string filename)
        {
            return new StreamReader(preparePath(filename));
        }

        public StreamWriter streamWriterFile(string filename)
        {
            string path = preparePath(filename + "_processed");
            File.WriteAllText(path, string.Empty);
            return new StreamWriter(path);
        }

        private string preparePath(string filename) 
        {
            string relation = @"..\..\..\texts\";
            string path = Path.Combine(Environment.CurrentDirectory, relation, filename + ".txt");
            return path;
        }
    }
}
