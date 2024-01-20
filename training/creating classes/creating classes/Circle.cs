using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_classes
{
    public class Circle
    {
        public void Radius2PerimeterArea()
        {
            string radious;
            decimal r, p, area;

            Console.WriteLine("Radious");
            Console.WriteLine();
            Console.WriteLine("Enter the Radious");

            radious = Console.ReadLine();
            r = decimal.Parse(radious);

            p = 2 * 22 / 7.0M * r;
            area = (22 / 7.0M) * r * r;

            string res = $"radius {r:0.00}";
            Console.WriteLine(res);

            res = $"Peremeter {p:0.00}  Area {area:0.00}";
            Console.Write(res);
        }
    }
}
