using System;

namespace DZ_Calc_20._10._2019_Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DPV.Soft_Calc_1.0.1");
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Введите 1 для сложения двух чисел\n" +
                    "Введите 2 для вычитания одного из другого\n" +
                    "Введите 3 для умножения\n" +
                    "Введите 4 для деления\n" +
                    "Введите 5 для выхода");
                int Key = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (Key == 5)
                {
                    Console.WriteLine("\nСпасибо досвидания... Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                }
                Console.Write("Введите первое число: ");
                int One = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.Write("Введите второе число: ");
                int Two = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                //Console.WriteLine("Key={0}, One={1}, Two={2}", Key, One, Two);
                //Console.Read();


                
                switch (Key)
                {
                    case 1:
                        Console.WriteLine("Сложение:\n{1}+{2}={0}", One + Two, One, Two);
                        break;
                    case 2:
                        Console.WriteLine("Вычитание:\n{1}-{2}={0}", One - Two, One, Two);
                        break;
                    case 3:
                        Console.WriteLine("Умножение:\n{1}*{2}={0}", One * Two, One, Two);
                        break;
                    case 4:
                        Console.WriteLine("Деление:\n{1}/{2}={0}", One / Two, One, Two);
                        break;
                    default:
                        break;
                }




                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
