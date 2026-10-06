using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВведите один символ: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || input.Length == 0)
            {
                Console.WriteLine("Ошибка: ничего не введено.");
                return;
            }

            char ch = input[0];
            int code = (int)ch;
            char nextCh = (char)(code + 1);

            Console.WriteLine($"Код символа '{ch}': {code}, следующий символ: '{nextCh}' (код: {(int)nextCh})");
        }
    }
}
