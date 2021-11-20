using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу: ");
            String text = Console.ReadLine();
            String[] words = text.Split();
            int maxword = 0;
            int index = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxword)
                {
                    maxword = words[i].Length;
                    index = i;
                }
            }
            Console.WriteLine("Самое длинное слово: {0}", words[index]);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
