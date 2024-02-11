using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Rectangle : Poligon
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle(double width, double heigth)
        {
            Width = width;
            Heigth = heigth;
        }

        public override double CalculateArea()
        {
            return Width * Heigth;
        }

    }
}
