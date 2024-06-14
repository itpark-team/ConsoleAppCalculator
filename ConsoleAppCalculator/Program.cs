using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleMathCalc simpleMathCalc = new SimpleMathCalc(3, 5);

            Console.WriteLine(simpleMathCalc.GetSum());
            Console.WriteLine(simpleMathCalc.GetSub());
        }
    }
}
