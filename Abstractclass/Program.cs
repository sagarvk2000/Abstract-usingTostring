using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(4);
            c1.CalculateArea();
            Console.WriteLine(c1);

            Rectangle r1 = new Rectangle(6, 5);
            r1.CalculateArea();
            Console.WriteLine(r1);
        }
    }
}
