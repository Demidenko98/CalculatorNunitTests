using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator1
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multi(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
           
        }

    }

    public static class StringMathCalculator
    {
        public static object Sum(this string str)
        {

            object result = new DataTable().Compute(str, null);
            return result;
          
        }
    }

    public static class StringLingvoCalculator
    {
        public static string Sum(this string str, string str1)
        {
            return string.Concat(str, str1);
      
        }
    }

}
