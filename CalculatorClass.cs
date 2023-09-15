using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Information<T> (T arg1, T arg2);

    internal class CalculatorClass
    {
        public Information<double> info;

        public double getSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double getDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public event Information<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                info += value;
            }
            remove
            {
                Console.WriteLine("Remove the Delegate");
                info -= value;
            }
        }

        public double getProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double getQuotient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
