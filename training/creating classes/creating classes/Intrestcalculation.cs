using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_classes
{
    public class Intrestcalculation
    {
        public void SimpleInterest()
        {
            decimal P, R, T;
            decimal SI;
            Console.WriteLine("Simple Interest calculation");
            Console.WriteLine();

            Console.WriteLine("Enter the value of Principle");
            P = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of Interest");
            R = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of Years");
            T = decimal.Parse(Console.ReadLine());

            SI = P * R * T / 100;

            string res = $"You enterd";
            Console.WriteLine(res);
            res = $"Principle: {P:0.00}  Interest: {R:0.00} Years: {T:0.00}";
            Console.WriteLine(res);

            res = $"Simple Interest:{SI:0.00}";
            Console.WriteLine(res);



        }
    }
}
