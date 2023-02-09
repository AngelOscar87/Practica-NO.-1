using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_velocidad__tiempo_y_distancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de velocidad, tiempo y distancia");
            Console.WriteLine("Ingrese el primer valor (v, t, d): ");
            string valor1 = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo valor (v, t, d): ");
            string valor2 = Console.ReadLine();

            Console.WriteLine("Ingrese el valor correspondiente (v, t, d): ");
            string valor3 = Console.ReadLine();

            double resultado = CalcularValorDesconocido(valor1, valor2, valor3);
            Console.WriteLine("El valor desconocido es: " + resultado);

            Console.ReadLine();
        }

        static double CalcularValorDesconocido(string valor1, string valor2, string valor3)
        {
            double num1 = Convert.ToDouble(valor1.Substring(1));
            double num2 = Convert.ToDouble(valor2.Substring(1));

            switch (valor3)
            {
                case "v":
                    return CalcularVelocidad(num1, num2);
                case "t":
                    return CalcularTiempo(num1, num2);
                case "d":
                    return CalcularDistancia(num1, num2);
                default:
                    return 0;
            }
        }

        static double CalcularVelocidad(double tiempo, double distancia)
        {
            return distancia / tiempo;
        }

        static double CalcularTiempo(double velocidad, double distancia)
        {
            return distancia / velocidad;
        }

        static double CalcularDistancia(double velocidad, double tiempo)
        {
            return velocidad * tiempo;
        }
    }
}
