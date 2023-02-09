using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_sueldo_neto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la cantidad de horas trabajadas:");
            int horasTrabajadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el salario bruto por hora:");
            int salarioBrutoPorHora = int.Parse(Console.ReadLine());

            int salarioBruto = horasTrabajadas * salarioBrutoPorHora;
            int salarioExtra = 0;
            if (horasTrabajadas > 44)
            {
                salarioExtra = (horasTrabajadas - 44) * (salarioBrutoPorHora * 30 / 100);
            }
            int salarioTotal = salarioBruto + salarioExtra;

            double afp = salarioTotal * 0.3;
            double seguro = salarioTotal * 0.10;
            double salarioNeto = salarioTotal - afp - seguro;

            Console.WriteLine("Salario bruto: " + salarioBruto);
            Console.WriteLine("Salario extra: " + salarioExtra);
            Console.WriteLine("Salario total: " + salarioTotal);
            Console.WriteLine("AFP (7.25%): " + afp);
            Console.WriteLine("Seguro de salud (3%): " + seguro);
            Console.WriteLine("Salario neto: " + salarioNeto);

            Console.ReadLine();
        }
    }
}
