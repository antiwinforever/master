using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Globalization;


namespace Zadachi
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class Worcks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Date { get; set; }



    }
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Worcks> Questions { get; set; }


        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=zadachi;Username=postgres;Password=morgan");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            string LoginRegType;
            string LoginName = "0";
            while (LoginName == "0")
            {
                LoginRegType = "0";
                while (LoginRegType != "1" & LoginRegType != "2")
                {
                    Console.WriteLine("Введите: \n1. Для входа \n2. Для регистрации");
                    LoginRegType = Console.ReadLine();
                }

                switch (LoginRegType)
                {
                    case "1":
                        LoginName = Login();
                        MenuUsers(LoginName);
                        break;
                    case "2":
                        LoginName = Reg();
                        break;
                    default:
                        break;
                }
            }


        }

        static string MenuUsers(string LoginName)
        {
            Console.WriteLine("Привет: " + LoginName);

            while (true)
            {
                

                Console.WriteLine("Введите 0 для выхода\n" +
                    "Введите 1 для добавления задачи");
                string MenuID = Console.ReadLine();
                switch (MenuID)
                {
                    case "1":
                        QuestionADD();
                        break;
                    case "0":
                        break;
                    default:
                        break;
                }
                if (MenuID=="0")
                {
                    break;
                }
            }


            return "0";
        }

        static string QuestionADD()
        {
            Random rnd = new Random();
            using (ApplicationContext context = new ApplicationContext())
            {
                DateTime DateNow = DateTime.Now;
                context.Questions.Add(new Worcks { Name = "", Description = "", Tag = "#" + rnd.Next() , CreationDate = DateNow, Date = DateTime.Now }) ;
                context.SaveChanges();

                Console.WriteLine("Задача добавлена!");

            }
            return "";
        }

        static string Reg()
        {
            string TempNewLogin;
            string TempNewPass;
            while (true)
            {

                TempNewLogin = "";
                TempNewPass = "";
                while (true)
                {
                    Console.WriteLine("Введите новое имя пользователя:");
                    TempNewLogin = Console.ReadLine();

                    if (TempNewLogin.Length > 4)
                    {

                        break;
                    }
                    Console.WriteLine("Введенное имя короче 5 символов...\nНажмите любую клавишу и попробуйте еще раз....");
                    Console.ReadKey();
                }

                while (true)
                {
                    Console.WriteLine("Введите новый пароль:");
                    TempNewPass = Console.ReadLine();
                    Console.WriteLine("Введите новый пароль еще раз:");

                    if (Console.ReadLine() == TempNewPass)
                    {
                        break;
                    }
                    Console.WriteLine("Пароли не совпадают...\nНажмите любую клавишу и попробуйте еще раз....");
                    Console.ReadKey();
                }
                //Console.WriteLine("Логин: " + TempNewLogin + "\nПароль: " + TempNewPass);
                using (ApplicationContext context = new ApplicationContext())
                {
                    
                    var testUser = context.Users.FirstOrDefault(b => b.Name == TempNewLogin);
                    if (testUser == null)
                    {
                        context.Users.Add(new User { Name = TempNewLogin, Password = TempNewPass });
                        context.SaveChanges();
                        Console.WriteLine("Вы успешно зарегистрировались!");
                        return TempNewLogin;
                    }
                    else
                    {
                        Console.WriteLine("Пользователь уже существует... Нажмите любуюклавишу и попробуйте еще раз...");
                        Console.ReadKey();
                    }

                }
                
            }
            
        }

        static string Login()
        {
            string TempLogin = "0";
            string TempPass = "0";

            while (true)
            {
                Console.WriteLine("Введите имя пользователя:");
                TempLogin = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                TempPass = Console.ReadLine();


                using (ApplicationContext context = new ApplicationContext())
                {

                    var testUser = context.Users.FirstOrDefault(b => b.Name == TempLogin & b.Password == TempPass);
                    if (testUser != null)
                    {
                        Console.WriteLine("Вы успешно вошли!");
                        return TempLogin;
                    }
                    else
                    {
                        Console.WriteLine("Что то пошло не так... Нажмите любуюклавишу и попробуйте еще раз...");
                        Console.ReadKey();
                    }

                }
            }
        }


        //static void Test()
        //{
        //    using (ApplicationContext context = new ApplicationContext())
        //    {
        //        Random rnd = new Random();
        //        var testBlog = context.Users.FirstOrDefault(b => b.Name == "http://test.com");
        //        if (testBlog != null)
        //        {
        //            context.Users.Add(new User { Name = "Test" + rnd.Next(), Password = "" + rnd.Next()} );
        //        }

        //        context.SaveChanges();

        //        //получаем объекты из бд и выводим на консоль
        //        var users = context.Users.ToList();
        //        Console.WriteLine("Users list:");
        //        foreach (User u in users)
        //        {
        //            Console.WriteLine($"{u.Id}.{u.Name} - {u.Password}");
        //        }

        //    }
        //}
    }
    
    





    
}
