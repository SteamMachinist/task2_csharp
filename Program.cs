/*
 * 28.  Прочитать текстовый файл. На отдельной форме вывести тот же текст, но в котором все числа записаны словами
 */

namespace task2_csharp
{
    internal class Program
    {
        readonly static FileHandler fileHandler = new FileHandler();
        readonly static Replacer replacer= new Replacer();

        static void Main(string[] args)
        {
            string filename = readFilename();
            string text = fileHandler.readFile(readFilename());
            Console.WriteLine(text);
            Console.WriteLine();
            text = replacer.replaceNumbersWithNumberNames(text);
            Console.WriteLine(text);
            fileHandler.writeFile(filename, text);
        }

        static string readFilename()
        {
            Console.Write("Enter filename to process: ");
            return Console.ReadLine();
        }
    }
}