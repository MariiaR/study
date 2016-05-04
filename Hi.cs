using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "What is your name?";
            string name;
            Console.WriteLine(hello);
            name = Console.ReadLine();
            string answer = "Hi,";
            Console.WriteLine(answer + name);
                     
        }
    }
}
