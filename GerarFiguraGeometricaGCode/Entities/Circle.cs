using System;
using System.Collections.Generic;
using System.Text;

namespace GerarFiguraGeometricaGCode.Entities
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        double area;
        public double Area()
        {
            area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }

        public override string ToString()
        {
            return "A área do círculo é: " + area + "\n"
                +"G0 X0 Y0" + "\n"
                +"G2 X0 Y0 J" + Radius;
        }
    }
}
