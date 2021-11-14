using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        private class Test
        {
            public void Print()
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.Write("9");
                    throw new Exception();
                }
                finally
                {
                    Console.Write("2");
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}