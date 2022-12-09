using System;
using System.Collections.Generic;
using System.Text;

namespace p2022_Koba_B_O_MCont_2
{
    /*
       Клас - це основний тип данмх у об'єктно орієнтовному С#. Собою представляє певний набір (інструкцію) полів, методів та властивостей
       , для подальшого створення об'єктів класу (якщо клас не статичний) та виконання дій над ними.
       Статичні класи - це зазвичай службові класи. Не можна створювати екземпляри даного класу, але вони дозволяють виконувати різні операції(наприклад Math.Pow(), Console.WriteLine())
       Об'єкт класу - це відповідна реалізація нестатичного класу. Із заповненими або ні полями.
       Модифікатори доступу private, public, protected призначені для інкапсуляції даних. Використовуються з  полями, методами, класами, структурами
       або властивостями для відповідного надання чи обмеження можливостей для користовуча або при наслідуванню. Елеменети з модифікатором public відкриті для доступу всюди, також при наслідування дані елементи наслідуються. 
       Елеменети з модифікатором private закриті для доступу із зовні, але з ними можна оперувати в середині класу або структури де вони ініціалізовані ; при наслідуванні дані елементи не наслідуються.
       Елеменети з модифікатором protected також як і private закриті для доступу із зовні, але при наслідування дані елементи наслідуються
    */
    internal class ComplexNumber
    {
        public ComplexNumber()
        {
        }
        public ComplexNumber(double act_arg, double img_arg)
        { 
            actual_part = act_arg;
            imaginary_part = img_arg;
        }
        private double actual_part;
        private double imaginary_part;
        public double Actual_Part { get { return actual_part; } }
        public double Imaginary_Part { get { return imaginary_part; } }
        public static ComplexNumber operator + (ComplexNumber cp1, ComplexNumber cp2)
        {
            return new ComplexNumber { actual_part = cp1.actual_part + cp2.actual_part , imaginary_part = cp1.imaginary_part + cp2.imaginary_part};
        }
        public static ComplexNumber operator + (double value, ComplexNumber cp)
        {
            return new ComplexNumber { actual_part = cp.actual_part + value, imaginary_part = cp.imaginary_part };
        }
        public static ComplexNumber operator + (ComplexNumber cp, double value)
        {
            return new ComplexNumber { actual_part = cp.actual_part + value, imaginary_part = cp.imaginary_part };
        }
        public static ComplexNumber operator - (ComplexNumber cp1, ComplexNumber cp2)
        {
            return new ComplexNumber { actual_part = cp1.actual_part - cp2.actual_part, imaginary_part = cp1.imaginary_part - cp2.imaginary_part };
        }
        public static ComplexNumber operator - (double value, ComplexNumber cp)
        {
            return new ComplexNumber { actual_part = cp.actual_part - value, imaginary_part = cp.imaginary_part };
        }
        public static ComplexNumber operator - (ComplexNumber cp, double value)
        {
            return new ComplexNumber { actual_part = cp.actual_part - value, imaginary_part = cp.imaginary_part };
        }
        public static ComplexNumber operator * (ComplexNumber cp1, ComplexNumber cp2)
        {
            return new ComplexNumber { actual_part = cp1.actual_part * cp2.actual_part - cp1.imaginary_part * cp2.imaginary_part, imaginary_part = cp1.actual_part * cp2.imaginary_part + cp1.imaginary_part * cp2.actual_part };
        }
        public static ComplexNumber operator * (ComplexNumber cp, double value)
        {
            return new ComplexNumber { actual_part = cp.actual_part * value, imaginary_part = cp.imaginary_part * value };
        }
        public static ComplexNumber operator * (double value, ComplexNumber cp)
        {
            return new ComplexNumber { actual_part = cp.actual_part * value, imaginary_part = cp.imaginary_part * value };
        }
        public static ComplexNumber operator /(ComplexNumber cp1, ComplexNumber cp2)
        {
            double divider = Math.Pow(cp2.actual_part, 2) + Math.Pow(cp2.imaginary_part, 2);
            return new ComplexNumber { actual_part = (cp1.actual_part * cp2.actual_part + cp1.imaginary_part * cp2.imaginary_part) / divider, imaginary_part = -((cp1.actual_part * cp2.imaginary_part - cp1.imaginary_part * cp2.actual_part) / divider) };
        }
        public static ComplexNumber operator / (double value, ComplexNumber cp)
        {
            return new ComplexNumber { actual_part = cp.actual_part / value, imaginary_part = cp.imaginary_part / value };
        }
        public static ComplexNumber operator / (ComplexNumber cp, double value)
        {
            return new ComplexNumber { actual_part = cp.actual_part / value, imaginary_part = cp.imaginary_part / value };
        }
        public override string ToString()
        {
            return $"{actual_part};{imaginary_part}";
        }
    }
}
