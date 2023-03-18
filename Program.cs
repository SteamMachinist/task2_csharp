/*
 * 28.  Прочитать текстовый файл. На отдельной форме вывести тот же текст, но в котором все числа записаны словами
 */

namespace task2_csharp
{
    internal class Program
    {
        readonly static FileHandler fileHandler = new FileHandler();
        readonly static Replacer replacer = new Replacer();

        static void Main(string[] args)
        {
            string filename = readFilename();
            
            using (var reader = fileHandler.streamReaderFile(filename))
            using (var writer = fileHandler.streamWriterFile(filename))
            {
                while (reader.Peek() >= 0)
                {
                    string processed = replacer.replaceNumbersWithNumberNames(reader.ReadLine());
                    writer.WriteLine(processed);
                }
            }
        }

        static string readFilename()
        {
            Console.Write("Enter filename to process: ");
            return Console.ReadLine();
        }
    }
}