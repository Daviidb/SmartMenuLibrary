using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        public static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }

        public static double Sum(double[] numbers)
        {
            double summen = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                summen += numbers[i];
            }
            return summen;
        }

        public static double Minimum(double[] numbers)
        {
            double mini = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < mini)
                {
                    mini = numbers[i];
                }
                
            }
            return mini;
        }

        public static double Maximum(double[] numbers)
        {
            double maxi = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxi)
                {
                    maxi = numbers[i];
                }

            }
            return maxi;
        }

        public static double Average(double[] numbers)
        {
            double aver = numbers[0];
            for (int i = 1; i < numbers.Length; i++) 
            {
                aver += numbers[i];
            }
            return aver / numbers.Length;
        }
    }
}
