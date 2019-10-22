using System;
using System.Collections.Generic;

namespace DZ_Calc_20._10._2019_Backend
{
    class Program
    {
        static List<string> history = new List<string>();

        static void HisAd(string Text)
        {
            history.Add(Text);
            Console.WriteLine(Text);
        }

        static void Main(string[] args)
        {
            
            //Console.WriteLine(Data[0]);
            //Data.RemoveAt(0);
            //Console.WriteLine(Data.Count);

            int One = 0, Two = 0, Key = 0;
            Console.WriteLine("DPV.Soft_Calc_1.0.5");
            
            
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
                    Console.WriteLine("\nСпаCибо До СвИдАнИя... Нажмите любую клавишу...");
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

                switch (Key)
                {
                    case 1:
                        HisAd("Сложение:\n" + One + "+" + Two + "=" + (One + Two));
                        break;
                    case 2:
                        HisAd("Вычитание:\n" + One + "-" + Two + "=" + (One - Two));
                        break;
                    case 3:
                        HisAd("Умножение:\n" + One + "*" + Two + "=" + (One * Two));
                        break;
                    case 4:
                        HisAd("Деление:\n" + One + "/" + Two + "=" + (One / Two));
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

                


                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
