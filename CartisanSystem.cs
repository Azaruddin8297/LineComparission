using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    public class CartisanSystem
    {
        public void method()
        {
         
            double x = 1;
            double y = 2;

            
            double x1 = 3;
            double y1 = 4;

          
            double slope = (y1 - y) / (x1 - x);

           
            double yIntercept = y - slope * x;

            string equation = $"y = {slope}x + {yIntercept}";

            Console.WriteLine($"Equation of the line: {equation}");

           
            double length = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2));

            Console.WriteLine($"Length of the line: {length}");

        }

    }
}
