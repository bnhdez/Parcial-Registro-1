using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, edad_s = 0, edad_e = 0, cant, enf = 0, sano = 0;
            double temp, prom_s, prom_e;
            string dpt, tos, fiebre;
            
            Console.WriteLine("********CONTROL DE SALUD*********");
            Console.WriteLine("Ingrese la cantidad de empleados a evaluar");
            cant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cant; i++)
            {
                Console.WriteLine();
                Console.Write("Ingrese sus edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el area en el que labora ('Mercadeo', 'IT', 'Recursos Humanos'): ");
                dpt = Console.ReadLine();
                Console.Write("Ingrese su temperatura corporal: ");
                temp = double.Parse(Console.ReadLine());
                Console.Write("Presenta tos? (SI o NO): ");
                tos = Console.ReadLine();
                Console.Write("Presenta fiebre? (SI o NO): ");
                fiebre = Console.ReadLine();

                if ((temp > 38) && (tos == "SI") && (fiebre == "SI") && (edad >= 0))
                {
                    enf = enf + 1;
                    edad_e = edad + edad_e;
                }
                else if ((temp <= 38) && (edad >= 0))
                {
                    sano = sano + 1;
                    edad_s = edad + edad_s;
                }
            }

            prom_e = edad_e / enf;
            prom_s = edad_s / sano;

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Empleados enfermos: " + enf);
            Console.WriteLine("Empleados sanos: " + sano);
            Console.WriteLine();
            Console.WriteLine("Promedio de Edad de Empleados sanos " + prom_s);
            Console.WriteLine("Promedio de Edad de Empleados enfermos " + prom_e);
        }
    }
}
