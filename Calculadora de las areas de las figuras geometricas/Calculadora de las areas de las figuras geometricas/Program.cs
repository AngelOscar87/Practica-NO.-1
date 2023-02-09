using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_las_areas_de_las_figuras_geometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora del área de Figuras Geométricas");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Pentagono");
            Console.WriteLine("5. Hexágono");
            Console.WriteLine("Elija una figura (1 - 5)");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("Introduzca el tamaño de las caras del cuadrado");
                    double caras = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El area del cuadrado es " + caras * caras);
                    break;

                case 2:
                    Console.WriteLine("Introduzca el radio del circulo: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del circulo es: " + Math.PI * radio * radio);
                    break;

                case 3:
                    Console.WriteLine("Introduce la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Introduce la altura: ");
                    double alutraTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del triangulo es: " + (baseTriangulo * alutraTriangulo) / 2)
                    break;

                case 4:
                    Console.WriteLine("Introduce el apotema del pentagono:");
                    double apotema = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduce la langitud del lado:");
                    double ladoPentagono = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del pentagono es: " + (ladoPentagono * apotema) / 2 * 5);
                    break;

                case 5:
                    Console.WriteLine("Introduce la apotema del hexágono");
                    double apotemaHexagono = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduce la longitud del lado");
                    double ladoHexagono = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del hexágono es: " + (ladoHexagono * apotemaHexagono) / 2 * 6);
                    break;

                default:
                    Console.WriteLine("La opción brindada no es vailida");
                    break;

            }

            Console.ReadLine
        }
    }
}
