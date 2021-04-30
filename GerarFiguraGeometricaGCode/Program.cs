using System;
using GerarFiguraGeometricaGCode;
using GerarFiguraGeometricaGCode.Entities;

namespace GerarFiguraGeometricaGCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Se quiser desenhar um retângulo, digite 1;");
            Console.WriteLine("Se quiser desenhar um círculo, digite 2;");
            Console.WriteLine("Se quiser desenhar um triângulo, digite 3.");
            Console.WriteLine("Digite um dos números acima:");
            n = int.Parse(Console.ReadLine());

            if (n == 1) {
                Console.WriteLine("Digite a largura do retângulo:");
                double larg = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do retângulo:");
                double alt = double.Parse(Console.ReadLine());

                Rectangle retangulo = new Rectangle();
                retangulo.Width = larg;
                retangulo.Height = alt;

                double area = retangulo.Area();

                Console.WriteLine(retangulo);
            }else if (n == 2){
                Console.WriteLine("Digite o raio do círculo:");
                double raio = double.Parse(Console.ReadLine());

                Circle circulo = new Circle();
                circulo.Radius = raio;
                double area;
                area = circulo.Area();

                Console.WriteLine(circulo);
            } else if(n == 3)
            {
                Console.WriteLine("Digite a largura do triângulo:");
                double larg = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do triângulo:");
                double alt = double.Parse(Console.ReadLine());

                Triangle trinagulo = new Triangle();
                trinagulo.Width = larg;
                trinagulo.Height = alt;

                double area = trinagulo.Area();

                Console.WriteLine(trinagulo);
            }
            else
            {
                Console.WriteLine("Número inválido!!");
            }

            
            
        }
    }
}
