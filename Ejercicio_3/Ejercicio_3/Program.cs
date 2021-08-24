using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, temp, cant, enf = 0, sano = 0;
            double total_s = 0, total_e = 0, prom_s, prom_e;
            string dpt, tos, fiebre;
            
            Console.WriteLine("********CONTROL DE SALUD*********");
            Console.WriteLine("Ingrese la cantidad de empeados a evaluar");
            cant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cant; i++)
            {
                Console.WriteLine();
                Console.Write("Ingrese sus edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el area en el que labora ('Mercadeo', 'IT', 'Recursos Humanos'): ");
                dpt = Console.ReadLine();
                Console.Write("Ingrese su temperatura corporal: ");
                temp = int.Parse(Console.ReadLine());
                Console.Write("Presenta tos? (SI o NO): ");
                tos = Console.ReadLine();
                Console.Write("Presenta fiebre? (SI o NO): ");
                fiebre = Console.ReadLine();

                if ((temp > 38) && (tos == "SI") && (fiebre == "SI"))
                {
                    enf = enf + 1;

                }
                else if (temp <= 38)
                {
                    sano = sano + 1;

                }
            }
            Console.WriteLine();
            Console.WriteLine("Empleados enfermos: " + enf);
            Console.WriteLine("Empleados sanos: " + sano);

        }
    }
}
