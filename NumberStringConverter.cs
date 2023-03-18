using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_csharp
{
    internal class NumberStringConverter
    {
        private static readonly string[] onesNames = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
        private static readonly string[] teensNames = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
        private static readonly string[] tensNames = {"", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семеьдесят", "восемьдесят", "девяносто"};
        private static readonly string[] hundresNames = { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятсот" };
        private static readonly string[] thousandsNames = { "одна", "две", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", };
        private static Dictionary<int, string> ones;
        private static Dictionary<int, string> teens;
        private static Dictionary<int, string> tens;
        private static Dictionary<int, string> hundreds;
        private static Dictionary<int, string> thousands;

        public static NumberStringConverter build()
        {
            NumberStringConverter mapper = new NumberStringConverter();
            ones = new Dictionary<int, string>();
            for (int i = 1; i < 10; i++)
            {
                ones.Add(i, onesNames[i - 1]);
            }
            teens = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                teens.Add(i, teensNames[i]);
            }
            tens = new Dictionary<int, string>();
            for (int i = 1; i < 10; i++)
            {
                tens.Add(i, tensNames[i - 1]);
            }
            hundreds = new Dictionary<int, string>();
            for (int i = 1; i < 10; i++)
            {
                hundreds.Add(i, hundresNames[i - 1]);
            }
            thousands = new Dictionary<int, string>();
            for (int i = 1; i < 10; i++)
            {
                thousands.Add(i, thousandsNames[i - 1] + " тысяч(и)");
            }
            return mapper;
        }

        public string convert(int number)
        {
            Console.WriteLine("new number " + number);
            string numeral = "";
            if (number == 0)
            {
                return "ноль";
            }
            int ranker = 1000;
            for(int i = 4; i > 0; i--)
            {
                int remainder = number % ranker;
                int current = number / ranker;
                number = remainder;
                Console.WriteLine("      ranker " + ranker);
                Console.WriteLine("   remainder " + remainder);
                Console.WriteLine("     current " + current);
                if (current == 0)
                {
                    ranker /= 10;
                    continue;
                }
                else
                {
                    switch (ranker)
                    {
                        case 1000:
                            numeral += thousands.GetValueOrDefault(current) + " ";
                            break;

                        case 100:
                            numeral += hundreds.GetValueOrDefault(current) + " ";
                            break;

                        case 10:
                            if (current == 1)
                            {
                                remainder = number % ranker;
                                current = number / ranker;
                                number = remainder;
                                numeral += teens.GetValueOrDefault(current + remainder) + " ";
                                i--;
                            }
                            else
                            {
                                numeral += tens.GetValueOrDefault(current) + " ";
                            }
                            break;

                        case 1:
                            numeral += ones.GetValueOrDefault(current) + " ";
                            break;
                    }
                    ranker /= 10;
                }
                
            }
            return numeral;
        }
    }
}
