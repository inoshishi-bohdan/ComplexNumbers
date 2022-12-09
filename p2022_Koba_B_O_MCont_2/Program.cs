using System;

namespace p2022_Koba_B_O_MCont_2
{
    internal class Program
    {
        /*
         Клас - це основний тип данмх у об'єктно орієнтовному С#. Собою представляє певний набір (інструкцію) полів, методів та властивостей
        , для подальшого створення об'єктів класу (якщо клас не статичний) та виконання дій над ними.
         Статичні класи - це зазвичай службові класи. Не можна створювати екземпляри даного класу, але вони дозволяють виконувати різні операції(наприклад Math.Pow(), Console.WriteLine())
         Об'єкт класу - це відповідна реалізація нестатичного класу. Із заповненими або ні полями.
         Модифікатори доступу private, public, protected призначені для інкапсуляції даних. Використовуються з  полями, методами, 
         або властивостями для відповідного надання чи обмеження можливостей для користовуча.
         */
        static void Main(string[] args)
        {
            ComplexNumber cn1 = new ComplexNumber(1, 7);
            ComplexNumber cn2 = new ComplexNumber(8, 5);
            Console.WriteLine(cn1 + cn2);
            Console.WriteLine(cn1 - cn2);
            Console.WriteLine(cn1 * cn2);
            Console.WriteLine(cn1 / cn2);
            Console.WriteLine(cn1 + 2);
            Console.WriteLine(2 - cn2);
            Console.WriteLine(cn2 * 2);
            Console.WriteLine(3 / cn2);
            Console.ReadLine();
        }
    }
}
