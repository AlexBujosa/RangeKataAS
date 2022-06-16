using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeKata
{
    public class Program
    {
       // public string[] symbol = { "[", "]", "(", ")" };
       
        public enum SymbolOpen
        {
            CorcheteAbierto = 0,
            ParentesisAbierto = 1
        }
        public enum SymbolClose
        { 
            CorcheteCerrado = 2,
            ParentesisCerrado = 3
        }


        static void Main(string[] args)
        {

        }
        public static string NumberContaining(int[] numberContaining)
        {
            string valueString = "{";
            for (int i = 0; i < numberContaining.Length - 1; i++)
            {
                valueString += numberContaining[i] + ",";
            }
            valueString += numberContaining[numberContaining.Length - 1] + "}";
            return valueString;

        }
        public static string GetAllPoints(int[]numberRange)
        {
            string allpoint = "{";
            for(int i = numberRange[0]; i<numberRange[1] - 1; i++)
            {
                allpoint += i + ",";
            }
            allpoint += (numberRange[1] - 1).ToString() + "}";
            return $"allPoints ={allpoint}";
        }
        public static string IntegerRangeContain(int fValue, int sValue, int[]values)
        {
            string valueString = "{";
            for(int i = 0; i<values.Length; i++)
            {
                if (fValue > values[i] || sValue < values[i])
                {
                    return $"[{fValue}, {sValue}) Doesn't contain " +NumberContaining(values);
                }
            }
            return $"[{fValue}, {sValue}) Doesn't contain " + NumberContaining(values);
        }
        public static string endPoints(SymbolOpen Op, SymbolClose Cl, int[] numberRange)
        {
            int fValue = numberRange[0];
            int sValue = numberRange[1];
            string OpenSymbol = "[";
            string CloseSymbol = "]";
            string OpenBraket = "{";
            string CloseBraket = "}";
            if (SymbolOpen.ParentesisAbierto == Op)
            {
                fValue += 1;
                OpenSymbol = "(";
            }

            if (SymbolClose.ParentesisCerrado == Cl)
            {
                sValue -= 1;
                CloseSymbol = ")";
            }
            return $"{OpenSymbol}{numberRange[0]}, {numberRange[1]}{CloseSymbol} endspoints = {OpenBraket} {fValue},{sValue}{CloseBraket}";
                

        }

        public static  string ContainRange()
        {
            return "Contain Range";
        }
        public static string OverlapRange()
        {
            return "Dont overlap";
        }
        public static string Equals()
        {
            return "equals";
        }

    }
}
