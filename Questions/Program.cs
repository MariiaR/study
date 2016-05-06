using System;
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
            DateTime birthDate = DateTime.ParseExact("05261992", "mmddyyyy", null);
            Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            string phone = Console.ReadLine();
            Console.WriteLine("What is your home address?");
            string address = Console.ReadLine();
            Console.WriteLine("Dear {0} {1}", name, surname);
            Console.ReadLine();
            
        }
    }
}
