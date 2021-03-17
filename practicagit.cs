/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
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