using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, temp, cant;
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

                if ()

            }


        }
    }
}
