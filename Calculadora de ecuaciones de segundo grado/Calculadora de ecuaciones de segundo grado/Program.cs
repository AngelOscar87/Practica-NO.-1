using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_ecuaciones_de_segundo_grado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolviendo ecuaciones de segundo grado");
            Console.WriteLine("Ingrese el coeficiente a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el coeficiente b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el coeficiente c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double[] soluciones = ResolverEcuacion(a, b, c);
            if (soluciones == null)
            {
                Console.WriteLine("La ecuación no tiene soluciones reales");
            }
            else
            {
                Console.WriteLine("La solución de la ecuación es: x1 = " + soluciones[0] + " y x2 = " + soluciones[1]);
            }

            Console.ReadLine();
        }

        static double[] ResolverEcuacion(double a, double b, double c)
        {
            double discriminante = b * b - 4 * a * c;
            if (discriminante < 0)
                return null;

            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            return new double[] { x1, x2 };
        }
    }
    
}
