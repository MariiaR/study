﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DateTime bD = Convert.ToDateTime(birthDate);
            TimeSpan Age = (DateTime.Today - bD);
            Console.WriteLine("What is your phone number?");
            string phone = Console.ReadLine();
            Console.WriteLine("What is your home address?");
            string address = Console.ReadLine();
            //Console.WriteLine(Age.ToString("dd:MM:yyyy"));
            Console.WriteLine("Dear {0},", name);
            Console.ReadLine();

        }
    }
}
