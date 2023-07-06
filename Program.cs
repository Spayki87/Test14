using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вывод_имени
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string middleLine = $"{symbol} {name} {symbol}";
            int lateralLine = middleLine.Length;
            string horizontalLine = new string(symbol, lateralLine);

            Console.WriteLine($"{horizontalLine}\n{middleLine}\n{horizontalLine}");
        }
    }
}
