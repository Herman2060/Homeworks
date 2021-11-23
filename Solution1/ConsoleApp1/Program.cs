using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(validBraces("[({})](]"));
        }

        public static bool validBraces(String braces)
        {
            Stack<char> _braces = new Stack<char>();

            // for (int i = 0; i < braces.Length; i++)
            // {
            //     if (braces[i] == '(' || braces[i] == '[' || braces[i] == '{')
            //     {
            //         _braces.Push(braces[i]);
            //     }
            //     else if (braces[i] == ')' || braces[i] == ']' || braces[i] == '}')
            //     {
            //         
            //     }
            // }

            char[] symbols = braces.ToCharArray();

            foreach (char symbol in symbols)
            {
                if (symbol == ']' && (_braces.Pop() != '['))
                {
                    return false;
                }
                else if (symbol == ')' && (_braces.Pop() != '('))
                {
                    return false;
                }
                else if (symbol == '}' && _braces.Pop() != '{')
                {
                    return false;
                }
                else if (symbol == '{' || symbol == '[' || symbol == '(')
                {
                    _braces.Push(symbol);
                }
            }
            
            if (_braces.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}