using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificación_Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número de calificaciones:");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduce la calificación " + (i + 1) + ":");
                int calificacion = int.Parse(Console.ReadLine());
                suma += calificacion;
            }

            double promedio = suma / (double)n;
            Console.WriteLine("El promedio de calificaciones es: " + promedio);

            if (promedio >= 90)
            {
                Console.WriteLine("El literal correspondiente es: A");
            }
            else if (promedio >= 80)
            {
                Console.WriteLine("El literal correspondiente es: B");
            }
            else if (promedio >= 70)
            {
                Console.WriteLine("El literal correspondiente es: C");
            }
            else if (promedio >= 60)
            {
                Console.WriteLine("El literal correspondiente es: D");
            }
            else
            {
                Console.WriteLine("El literal correspondiente es: F");
            }

            Console.ReadLine();
        }
    }
}
