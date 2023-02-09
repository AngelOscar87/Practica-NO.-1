using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_funciones_trigonometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcualdora de funciones trigonométricas");
            Console.WriteLine("1. Seno");
            Console.WriteLine("2. Coseno");
            Console.WriteLine("3. Secante");
            Console.WriteLine("4. Cosecante");
            Console.WriteLine("5. Tangente");
            Console.WriteLine("6. Cotangente");
            Console.WriteLine("Elija una función (1-6)");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el ángulo en grados:");
            double angulo = Convert.ToDouble(Console.ReadLine());

            double anguloRadianes = (Math.PI / 180) * angulo;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El seno del ángulo es: " + Math.Sin(anguloRadianes));
                    break;

                    case 2:
                    Console.WriteLine("El coseno del ángulo es: " + Math.Cos(anguloRadianes));
                    break;

                    case 3:
                    Console.WriteLine("La secante del ángulo es: " + (1 / Math.Cos(anguloRadianes)));
                    break;

                    case 4:
                    Console.WriteLine("La cosecabte del ángulo es: " + (1 / Math.Sin(anguloRadianes)));
                    break;

                    case 5:
                    Console.WriteLine("La tangente del ángulo es: " + Math.Tan(anguloRadianes));
                    break;

                    case 6:
                    Console.WriteLine("La cotangente del ángulo es: " + (1 / Math.Tan(anguloRadianes)));
                    break;

                    default:
                    Console.WriteLine("El valor ingresado no es valido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
