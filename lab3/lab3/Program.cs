using System;

namespace lab3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число с точкой: ");
            //user_input = Convert.ToDouble(Console.ReadLine());
            float user_input = float.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int user_input2 = int.Parse(Console.ReadLine());


            float a, b, c, d;
            a = user_input + user_input2;  
            b = user_input - user_input2;
            c = user_input * user_input2;
            d = user_input / user_input2;

            Console.WriteLine("Переменная: " + a);
            Console.WriteLine("Вычитание: " + b);
            Console.WriteLine("Умножение: " + c);
            Console.WriteLine("Деление: " + d);
        }
    }
}
