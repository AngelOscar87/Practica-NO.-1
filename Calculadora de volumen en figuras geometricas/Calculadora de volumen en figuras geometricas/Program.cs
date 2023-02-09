using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_volumen_en_figuras_geometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de volumen en figuras geométricas");
            Console.WriteLine("1. Cubo");
            Console.WriteLine("2. Esfera");
            Console.WriteLine("3. Cono");
            Console.WriteLine("4. Pirámide");
            Console.WriteLine("Elija una figura (1-4)");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Introduce el lado del cubo:");
                    double ladoCubo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("El volumen del cubo es" + ladoCubo * ladoCubo * ladoCubo);
                    break;

                case 2:
                    Console.WriteLine("Introduzca el reado de la esfera");
                    double radioEsfera = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El volumen del la esfera es:" + (4.0 / 3.0) * Math.PI * radioEsfera * radioEsfera * radioEsfera);
                    break;

                case 3:
                    Console.WriteLine("Introduce la altura del cono");
                    double alturaCono = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduce el radio del cono");
                    double radioCono = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El volumen del cono es: " + (Math.PI * radioCono * radioCono * alturaCono));
                    break; 

                case 4:
                    Console.WriteLine("Introduce la base de la piramide ");
                    double basePiramide = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Intrudce la altura del triangulo");
                    double alturaPiramide = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El volumen de la pirámide es: " + (basePiramide * alturaPiramide) / 3);
                    break;

               default;
                    Console.WriteLine("El valor brindado no es valido");
                    break;

            }
            Console.ReadLine();
        }
    }
}
