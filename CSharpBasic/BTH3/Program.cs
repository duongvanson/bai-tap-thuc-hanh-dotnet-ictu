using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fra1 = new Fraction(-3, 1);
            Fraction fra2 = new Fraction(3, 1);
            Console.WriteLine("{0} + {1} = {2} ",fra1.ToString(),fra2.ToString(),fra1.plus(fra2).ToString());
            Console.WriteLine("{0} * {1} = {2} ", fra1.ToString(), fra2.ToString(), fra1.multiply(fra2).ToString());
            //fra1.simplify();
            //Console.WriteLine(fra1.ToString());
            Console.ReadKey();
        }
    }
}
