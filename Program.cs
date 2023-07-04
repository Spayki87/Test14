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
            string name;
            char symbol;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите символ: ");
            symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            PrintNameInRectangle(name, symbol);
        }

        static void PrintNameInRectangle(string name, char symbol)
        {
            int length = name.Length;

            Console.WriteLine(new string(symbol, length + 4));

            Console.WriteLine($"{symbol} {name} {symbol}");

            Console.WriteLine(new string(symbol, length + 4));
        }
    }
}
