using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    public class Line
    {
            public double X1 { get; }
            public double Y1 { get; }
            public double X2 { get; }
            public double Y2 { get; }

            public Line(double x1, double y1, double x2, double y2)
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Line))
                {
                    return false;
                }

                var other = (Line)obj;
                return X1 == other.X1 && Y1 == other.Y1 && X2 == other.X2 && Y2 == other.Y2;
            }

            public override int GetHashCode()
            {
                return Tuple.Create(X1, Y1, X2, Y2).GetHashCode();
            }
        }

        
    
}
