
using System;

namespace example1
{
    internal class Program
    {
         public static void Main (string [] args)
        {
           int a=0, b=0;
           Console.WriteLine("Introduzca a:");
           a=Int32.Parse(Console.ReadLine());
           
           Console.WriteLine("Introduzca b:");
           b=Int32.Parse(Console.ReadLine());
           
           Console.WriteLine($"Adding {a} * {b} es igual a {AddNumbers(a, b)}");
        }

        public static int AddNumbers (int a, int b)
        {
            return a*b;
        }
    }
}
