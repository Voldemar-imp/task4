using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string zodiacSign;
            string jobPlace;

            Console.Write("Введите Ваше имя: ");
                name = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
                age = Console.ReadLine ();
            Console.Write("Введите Ваш знак зодиака: ");
                zodiacSign = Console.ReadLine ();
            Console.Write("Введите Ваше место работы: ");
                jobPlace = Console.ReadLine ();

            Console.WriteLine ("Вас зовут {0}, вам {1} год, вы {2} и работаете на {3}.", 
                name, age, zodiacSign, jobPlace);
        }
    }
}
