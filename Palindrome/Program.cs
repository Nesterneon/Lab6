using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text= Console.ReadLine();
            String[] words = text.Split();
            String result = "";
            foreach (string s in words) 
            {
                result += s.ToLower();
            }
            String reversetext = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                reversetext += result[i];
            }
            if (result == reversetext)
                Console.WriteLine("введенная строка является палиндромом.");
            else
                Console.WriteLine("Введенная строка не является палиндромом.");
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }  
    }
}
