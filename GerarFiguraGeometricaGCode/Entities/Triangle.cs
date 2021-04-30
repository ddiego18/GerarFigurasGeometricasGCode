using System;
using System.Collections.Generic;
using System.Text;

namespace GerarFiguraGeometricaGCode.Entities
{
    class Triangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Triangle()
        {

        }

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        double area;

        public double Area()
        {
            area = Width * Height / 2;
            return area;
        }

        public override string ToString()
        {
            return "A área do triângulo é: " + area + "\n"
                +"G0 X0 Y0" + "\n"
                +"G1 X0 Y0" + "\n"
                +"G1 X" + Width + " Y0" + "\n"
                +"G1 X" + Width/2 + " Y" + Height + "\n"
                + "G1 X0 Y0";
        }
    }
}
