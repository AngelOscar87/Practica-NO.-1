using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_permutaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de permutaciones");
            Console.WriteLine("1. Permutaciones con repetición");
            Console.WriteLine("2. Permutaciones sin repetición");
            Console.WriteLine("Elija una opción (1-2):");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el número de elementos (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el número de permutaciones (r):");
            int r = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El resultado de la permutación es: " + PermutacionConRepeticion(n, r));
                    break;

                case 2:
                    Console.WriteLine("El resultado de la permutación sin repitución es " + PermutacionesSinRepetición(n, R));
                    break;

                default:
                    Console.WriteLine("Los caracteres insertados no son validos");
                    break;

            }

            Console.ReadLine();
                
        }

        static int PermutacionesConRepeticion(int n, int r)
        {
            return (int)Math.Pow(n, r);
        }
        static int PermutacionesSinRepeticion(int n, int r)
        {
            return Factorial(n) / Factorial(n - r);
        }
        static int Factorial(int n)
        {
            if (n == 0) 
                return 1;

            int resultado = 1;
            for (int i = 1; i <= n;  i++)
            {
                resultado *= i;
            }
            return resultado;
        }

    }
}
