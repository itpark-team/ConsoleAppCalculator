using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculator
{
    public class SimpleMathCalc
    {
        private double a;
        private double b;

        public SimpleMathCalc(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetSum()
        {
            return a + b + 1;
        }

        public double GetSub()
        {
            return a - b;
        }

        public double GetDev()
        {
            if (b == 0)
            {
                throw new Exception("Error. b == 0");
            }
            return a / b;
        }
    }
}
