using System;
using System.Collections.Generic;
using System.Text;

namespace GerarFiguraGeometricaGCode.Entities
{
    class Diamond
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Diamond()
        {

        }

        public Diamond(double width, double height)
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
            return "A área do losando é: " + area + "\n"
                + "G0 X0 Y0" + "\n"
                + "G1 X0 Y0" + "\n"
                + "G1 X" + Width/2 + " Y" + -Height/2 + "\n"
                + "G1 X" + Width + " Y0" + "\n"
                + "G1 X" + Width/2 + " Y" + Height/2 + "\n"
                + "G1 X0 Y0";
        }
    }
}
