using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora de Combinaciones");
            Console.WriteLine("1. Combinaciones con Repetición");
            Console.WriteLine("2. Combinaciones sin Repetición");
            Console.WriteLine("Elija una opción (1-2): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el número de elementos (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el número de combinaciones (r): ");
            int r = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El resultado de la combinación con repetición es: " + CombinacionConRepeticion(n, r));
                    break;
                case 2:
                    Console.WriteLine("El resultado de la combinación sin repetición es: " + CombinacionSinRepeticion(n, r));
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            Console.ReadLine();
        }

        static int CombinacionConRepeticion(int n, int r)
        {
            return Factorial(n + r - 1) / (Factorial(r) * Factorial(n - 1));
        }

        static int CombinacionSinRepeticion(int n, int r)
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1;

            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

    }
    
}
