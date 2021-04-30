using System;
using System.Collections.Generic;
using System.Text;

namespace GerarFiguraGeometricaGCode.Entities
{
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
      

        public Rectangle()
        {

        }

        public Rectangle(double width, double heigth, double area)
        {
            Width = width;
            Height = heigth;
        }

        double area;
        public double Area()
        {
            area = Width * Height;
            return area;
        }

        public override string ToString()
        {
            return "A área do retângulo é: " + area + "\n"
                +"G0 X0 Y0" + "\n"
                + "G1 X0 Y0" + "\n"
                + "G1 X"+Width+" Y0" + "\n"
                + "G1 X"+Width+" Y"+Height + "\n"
                + "G1 X0 Y"+Height + "\n"
                + "G1 X0 Y0";
        }
    }
}
