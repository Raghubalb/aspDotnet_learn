using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_classes
{
    public class NumberComparision
    {
        public void Findgreater()
        {
            string fn,sn;
            double n1, n2;
            double g;

            Console.WriteLine("Bigger number");
            Console.WriteLine();
            Console.WriteLine("Enter the First number");

            fn = Console.ReadLine();
            n1 = double.Parse(fn);
            Console.WriteLine("Enter the second number");

            sn = Console.ReadLine();
            n2 = double.Parse(sn);

            g = (n1 > n2) ? n1 : n2;

            string res = $"The bigger{g}";
            Console.WriteLine(res);

        }
    }
}
