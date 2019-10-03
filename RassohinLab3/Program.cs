using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RassohinLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ПАЛИНДРОМ - Слово или фраза, которые одинаково читаются слева направо и справа налево
            Console.WriteLine("Введите строку, а мы определим, является ли она палиндромом");
            string s = Console.ReadLine();
            string result = palindrom(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //реализация рекурсии
        public static string palindrom(string s)
        {
            if (s.Length == 1)
            {
                return "YES"; //если строка из одного символа, то она по умолчанию палиндром 
            } else
            {
                if (s.Substring(0, 1).Equals(s.Substring(s.Length - 1))) //Извлекаем первый символ, сравниваем этот экземляр с последним
                {
                    if (s.Length == 2)
                    {
                        return "YES"; //если символы равны и длина строки равна двум, то это успех
                    }

                    //если длина строки больше, пользуемся рекурсией
                    //передаем новую строку, исключив из текущий первый и последний символ
                    return palindrom(s.Substring(1, s.Length - 2));
                }
                else
                {
                    return "NO";
                }
            }
        }
    }
}
