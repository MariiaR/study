using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Questions
{
    class Program
    {
        // Ты очень хорошо все сделала! Молодец!
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your surname?");
            string surname = Console.ReadLine();

            Console.WriteLine("When were you born?");
            try
            {
                string birthDate = Console.ReadLine();


                // ты делаешь одну и ту же операцию 3 раза DateTime.Parse(birthDate)
                // в данном случае - это не страшно, но такие операции могут быть очень долгими, да и просто это дурной тон

                //int birthYear = DateTime.Parse(birthDate).Year;
                //int birthMonth = DateTime.Parse(birthDate).Month;
                //int birthDay = DateTime.Parse(birthDate).Day;

                // лучше написать так

                DateTime birthDateTime = DateTime.Parse(birthDate);
                // и везде использовать новую переменную, например: birthDateTime.Day
                int age = DateTime.Today.Year - birthDateTime.Year;

                Console.WriteLine("What is your phone number?");
                string phone = Console.ReadLine();

                Console.WriteLine("What is your home address?");
                string address = Console.ReadLine();

                //Console.WriteLine("Dear {0} {1}, {2}.{3}.{4} you will have your {5} birthday", name, surname, birthDay, birthMonth, yearNow, age);

                // DateTime имеет множество способов форматирования, например: {0:MM:ss} выведет месяц и секунды
                Console.WriteLine("Dear {0} {1}, {2:dd.MM.yyyy} you will have your {3} birthday", name, surname, birthDateTime, age);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type the right date");
            }

            // что если пользователь введет неверную дату?
            // почитай про try catch и попробуй обработать неверный ввод (подсказка: используй цикл "пока пользователь не ввел нормальную дату")

            Console.ReadLine();
        }
    }
}
