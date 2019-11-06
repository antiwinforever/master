using System;
using Persons;
using ConsoleApp;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Line Repa = new Line();
            Repa.pull();
        }
    }

    public class Turnip
    {
        public void TurnPull()
        {
            Console.WriteLine("Меня вытянули!!!");
        }
    }
    
    public class Line
    {
        grandfather grandfather = new grandfather("Дед", 1);
        grandmather grandmather = new grandmather("Бабка", 1);
        granddauther granddauther = new granddauther("Внучка", 1);
        cat cat = new cat("Кошка", 1);
        mouse mouse = new mouse("Мышка", 1);
        dog dog = new dog("Собака", 1);

       

        public void pull()
            {
                if (grandfather is grandfather)
                {
                    Console.WriteLine(grandfather.Name + " тянет репку...");
                    if (grandmather is grandmather)
                    {
                        Console.WriteLine(grandmather.Name + " тянет репку...");
                        if (granddauther is granddauther)
                        {
                            Console.WriteLine(granddauther.Name + " тянет репку...");
                            if (cat is cat)
                            {
                                Console.WriteLine(cat.Name + " тянет репку...");
                                if (mouse is mouse)
                                {
                                    Console.WriteLine(mouse.Name + " тянет репку...");
                                    if (dog is dog)
                                    {
                                        Console.WriteLine(dog.Name + " тянет репку...");
                                        Turnip YesPull = new Turnip();
                                        YesPull.TurnPull();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ктото халявит...");

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ктото халявит...");

                                }
                            }
                            else
                            {
                                Console.WriteLine("Ктото халявит...");

                            }
                        }
                        else
                        {
                            Console.WriteLine("Ктото халявит...");

                        }
                    }
                    else
                    {
                    Console.WriteLine("Ктото халявит...");

                    }
                }
                else
                {
                    Console.WriteLine("Ктото халявит...");
                }
        }
    }

    public class Family
    {
        public string Name;
        public int Age;

        public Family(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}

namespace Persons
{
    public class grandfather : Family
    {
        public grandfather(string Name, int Age) : base(Name, Age) { }
    }

    public class grandmather : Family
    {
        public grandmather(string Name, int Age) : base(Name, Age) { }
    }

    public class granddauther : Family
    {
        public granddauther(string Name, int Age) : base(Name, Age) { }
    }

    public class cat : Family
    {
        public cat(string Name, int Age) : base(Name, Age) { }
    }

    public class dog : Family
    {
        public dog(string Name, int Age) : base(Name, Age) { }
    }

    public class mouse : Family
    {
        public mouse(string Name, int Age) : base(Name, Age) { }
    }
}