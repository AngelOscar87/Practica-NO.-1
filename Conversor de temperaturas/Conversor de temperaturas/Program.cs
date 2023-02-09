using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperaturas");
            Console.WriteLine("Ingrese la temperatura a convertir: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la unidad de medida de la temperatura (C, K, F): ");
            string unidad = Console.ReadLine();

            Console.WriteLine("Ingrese la unidad de medida a la que desea convertir (C, K, F): ");
            string unidadConversion = Console.ReadLine();

            double resultado = ConvertirTemperatura(temperatura, unidad, unidadConversion);
            Console.WriteLine("La temperatura convertida es: " + resultado);

            Console.ReadLine();
        }

        static double ConvertirTemperatura(double temperatura, string unidad, string unidadConversion)
        {
            switch (unidad)
            {
                case "C":
                    temperatura = ConvertirDesdeCelsius(temperatura, unidadConversion);
                    break;
                case "K":
                    temperatura = ConvertirDesdeKelvin(temperatura, unidadConversion);
                    break;
                case "F":
                    temperatura = ConvertirDesdeFahrenheit(temperatura, unidadConversion);
                    break;
                default:
                    break;
            }

            return temperatura;
        }

        static double ConvertirDesdeCelsius(double temperatura, string unidadConversion)
        {
            switch (unidadConversion)
            {
                case "K":
                    return temperatura + 273.15;
                case "F":
                    return (temperatura * 9 / 5) + 32;
                default:
                    return temperatura;
            }
        }

        static double ConvertirDesdeKelvin(double temperatura, string unidadConversion)
        {
            switch (unidadConversion)
            {
                case "C":
                    return temperatura - 273.15;
                case "F":
                    return (temperatura * 9 / 5) - 459.67;
                default:
                    return temperatura;
            }
        }

        static double ConvertirDesdeFahrenheit(double temperatura, string unidadConversion)
        {
            switch (unidadConversion)
            {
                case "C":
                    return (temperatura - 32) * 5 / 9;
                case "K":
                    return (temperatura + 459.67) * 5 / 9;
                default:
                    return temperatura;
            }
        }
    }
}
