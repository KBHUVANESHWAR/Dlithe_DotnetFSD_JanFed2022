// See https://aka.ms/new-console-template for more information
using System;

namespace Program3
{
    class Swap
    {
        static void Main(String[] args)
        {
            Console.WriteLine("a: ");
            string a = Console.ReadLine();
            int val1 = Convert.ToInt32(a);  //50
            Console.WriteLine("b: ");
            string b = Console.ReadLine();
            int val2 = Convert.ToInt32(b);  //35
            Console.WriteLine("Before Swap:");
            Console.WriteLine("a: " + val1);
            Console.WriteLine("b: " + val2);
            val1 = val1 + val2;            // 85=50+35
            val2 = val1 - val2;           // 50=85-35
            val1 = val1 - val2;           // 35=85-50
            Console.WriteLine("After Swap:");
            Console.WriteLine("a: " + val1);
            Console.WriteLine("b: " + val2);
        }


    }
}
