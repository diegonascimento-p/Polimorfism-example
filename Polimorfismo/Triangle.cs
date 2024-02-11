using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Triangle : Poligon
    {
        public double Base { get; set; }
        public double Heigth { get; set; }

        public Triangle(double tBase, double heigth)
        {
            Base = tBase;
            Heigth = heigth;
        }

        public override double CalculateArea()
        {
            return (Base * Heigth) / 2;
        }
    }
}
