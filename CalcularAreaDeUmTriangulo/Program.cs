// Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
// válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
// possui a maior área.

using System;
using System.Globalization;

namespace MedidaDosLadosDeDoisTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite os valores do lado do triangulo X");
            Console.WriteLine(" ");
            Console.Write("Digite o valor de A: ");
            double ax = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            double bx = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            double cx = double.Parse(Console.ReadLine());

            double px = (ax + bx + cx) / 2;
            double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
            Console.WriteLine(" ");
            Console.WriteLine("Programa que calcula a medida de dois triangulos");
            Console.WriteLine("Digite os valores do lado do triangulo Y");
            Console.Write("Digite o valor de A: ");
            double ay = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            double by = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            double cy = double.Parse(Console.ReadLine());

            double py = (ay + by + cy) / 2;
            double areay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

            Console.WriteLine(" ");
            Console.WriteLine("Area do triangulo X = {0:F4}", areax);
            Console.WriteLine("Area do triangulo y = {0:F4}", areay);
            Console.WriteLine(" ");
            if (areax > areay)
            {
                Console.WriteLine("A maior area é a do triangulo X");
            }
            else
            {
                Console.WriteLine("A maior area é a do triangulo Y");
            }
            }
        }
}