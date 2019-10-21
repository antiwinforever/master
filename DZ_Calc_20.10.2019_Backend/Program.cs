using System;

namespace DZ_Calc_20._10._2019_Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            int One = 0, Two = 0, Key = 0;
            Console.WriteLine("DPV.Soft_Calc_1.0.1");
            string[] history = new string[5];
            int i = 0;
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Введите 1 для сложения двух чисел\n" +
                    "Введите 2 для вычитания одного из другого\n" +
                    "Введите 3 для умножения\n" +
                    "Введите 4 для деления\n" +
                    "Введите 5 для выхода\n" +
                    "Введите 6 для вывода истории");
                Key = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (Key == 5)
                {
                    Console.WriteLine("\nСпасибо досвидания... Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                }
                if (Key != 6)
                {
                    Console.Write("Введите первое число: ");
                    One = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Введите второе число: ");
                    Two = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                
                
               

                if (i > 4) i = 0;
                
                switch (Key)
                {
                    case 1:
                        history[i] = "Сложение:\n" + One + "+" + Two + "=" + (One + Two);
                        Console.WriteLine(history[i]);
                        break;
                    case 2:
                        history[i] = "Вычитание:\n" + One + "-" + Two + "=" + (One - Two);
                        Console.WriteLine(history[i]);
                        break;
                    case 3:
                        history[i] = "Умножение:\n" + One + "*" + Two + "=" + (One * Two);
                        Console.WriteLine(history[i]);
                        break;
                    case 4:
                        history[i] = "Деление:\n" + One + "/" + Two + "=" + (One / Two);
                        Console.WriteLine(history[i]);
                        break;
                    case 6:
                        Console.WriteLine("История:");
                        foreach (var his in history)
                        {
                            if (his != null) Console.WriteLine(his);
                        }
                        break;
                    default:
                        break;
                }

                i++;


                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
