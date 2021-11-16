using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Class1
    {
        private enum TaxVariant : int
        {
            MainTax = 1,
            ExtraTax = 2
        }

        private static TaxVariant _taxMainVar = TaxVariant.MainTax;
        private static TaxVariant _taxExtraVar = TaxVariant.ExtraTax;
        
        private static Dictionary<string, int> Tax = new Dictionary<string, int>(); 
        private static Dictionary<string, int> AdditionalTax = new Dictionary<string, int>();
        
        
        public static void SetTax(string country, int value, int TaxVar)
        {
            if (ValueValid(value))
            {
                if (TaxVar == (int) _taxMainVar)
                {
                    Tax[country] = value;
                }
                else if (TaxVar == (int) _taxExtraVar)
                {
                    AdditionalTax[country] = value;
                }
                else
                {
                    Console.WriteLine("Ты дурак?");
                }
            }
        }

        public static void SetNewCountry(string country, int value, int TaxVar)
        {
            if (TaxVar == (int) _taxMainVar)
            {
                if (!Tax.ContainsKey(country))
                {
                    if (ValueValid(value))
                    {
                        Tax[country] = value;
                    }
                }
                else
                {
                    Console.WriteLine("This country already exist");
                }
            }
            else if(TaxVar == (int)_taxExtraVar)
            {
                if (!AdditionalTax.ContainsKey(country))
                {
                    if (ValueValid(value))
                    {
                        AdditionalTax[country] = value;
                    }
                }
                else
                {
                    Console.WriteLine("This country already exist");
                }
            }
        }

        private static bool ValueValid(int value)
        {
            if (value > 0 && value < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static int TaxValue(string country, out int addValue)
        {
            addValue = AdditionalTax.ContainsKey(country) ? AdditionalTax[country] : 0;
            return Tax[country];
        }
    }
}