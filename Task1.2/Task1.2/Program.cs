using System;
using ClassLibrary1;

namespace Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Class1.SetTax("Ukraine", 20, 1);
            Class1.SetTax("Ukraine", 3, 2);

            Console.WriteLine(Class1.TaxValue("Ukraine", out int x));

            Console.WriteLine(x);
        }
    }
}