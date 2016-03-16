using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите число, квадрат которого хотите получить: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ответ: " + a*a);
            Console.ReadKey();


        }
    }
}
