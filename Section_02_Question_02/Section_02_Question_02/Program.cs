using System;

namespace Section_02_Question_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter integer for a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter integer for b: ");
            b = Convert.ToInt32(Console.ReadLine());

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine("a = {0}, b = {1}", a,b);
        }
    }
}
