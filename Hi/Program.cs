using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi
{
    class Program
    {
        static void Main(string[] args)
        {
            // некоторые переменные только усложняют чтение программы, можно обойтись и без них
            Console.WriteLine("What is your name?");

            // здесь переменная позволяет лучше понять смысл программы
            string name = Console.ReadLine();

            // Console.WriteLine(answer + name); так лучше не писать. Прочитай материал из книжки про string.Format(...) и по ссылке
            // https://msdn.microsoft.com/en-us/library/system.string.format(v=vs.110).aspx

            Console.WriteLine("Hi {0}!", name);

            // Можно было написать
            // Console.WriteLine("Hi {0}!", Console.ReadLine());
            // не объявляя name, но это ухудшает читабельность

            Console.ReadLine();
        }
    }
}
