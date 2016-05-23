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
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            string surname = Console.ReadLine();
            Console.WriteLine("When were you born?");
            string birthDate = Console.ReadLine();
            //birthDate = DateTime.Parse(birthDate).ToShortDateString();
            int yearNow = DateTime.Today.Year;
            int birthYear = DateTime.Parse(birthDate).Year;
            int birthMonth = DateTime.Parse(birthDate).Month;
            int birthDay = DateTime.Parse(birthDate).Day;
            int age = yearNow - birthYear;
            Console.WriteLine("What is your phone number?");
            string phone = Console.ReadLine();
            Console.WriteLine("What is your home address?");
            string address = Console.ReadLine();
            //Console.WriteLine(Age.ToString("dd:MM:yyyy"));
            Console.WriteLine("Dear {0} {1}, {2}.{3}.{4} you will have your {5} birthday", name, surname, birthDay, birthMonth, yearNow, age);
            Console.ReadLine();

        }
    }
}
