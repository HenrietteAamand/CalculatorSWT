using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalclatorClass
    {
        public double Add(double a, double b)
        {
            double result;
            result = a + b;

            return result;
        }

        public double Subtract(double a, double b)
        {
            double result;
            result = a - b;

            return result;
        }

        public double Multiply(double a, double b)
        {
            double result;
            result = a*b;

            return result;
        }

        public double Power(double x, double exp)
        {
            double result;
            result = Math.Pow(x, exp);

            return result;
        }
    }
}
