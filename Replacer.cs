using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_csharp
{
    internal class Replacer
    {
        NumberStringConverter mapper = NumberStringConverter.build();
        public string replaceNumbersWithNumberNames(string text) 
        {
            return mapper.convert(int.Parse(text));
        }

        //private static string
    }
}
