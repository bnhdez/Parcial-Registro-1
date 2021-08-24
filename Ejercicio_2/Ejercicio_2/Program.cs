using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int años;
            double sueldo, aumento, n_sueldo;

            Console.Write("Ingrese los años de antigüedad: ");
            años = int.Parse(Console.ReadLine());
            Console.Write("Ingrese sus sueldo: ");
            sueldo = double.Parse(Console.ReadLine());

            if (años == 5)
            {
                aumento = sueldo * 0.05;
                n_sueldo = aumento + sueldo;
                Console.WriteLine("Sus años en la empresa son " + años + ", contando con un bono de $" + aumento + " y un nuevo sueldo de $" + n_sueldo);
            }
            else if (años == 10)
            {
                aumento = sueldo * 0.08;
                n_sueldo = aumento + sueldo;
                Console.WriteLine("Sus años en la empresa son " + años + ", contando con un bono de $" + aumento + " y un nuevo sueldo de $" + n_sueldo);
            }
            else if (años == 15)
            {
                aumento = sueldo * 0.10;
                n_sueldo = aumento + sueldo;
                Console.WriteLine("Sus años en la empresa son " + años + ", contando con un bono de $" + aumento + " y un nuevo sueldo de $" + n_sueldo);
            }
            else if (años > 15)
            {
                aumento = sueldo * 0.15;
                n_sueldo = aumento + sueldo;
                Console.WriteLine("Sus años en la empresa son " + años + ", contando con un bono de $" + aumento + " y un nuevo sueldo de $" + n_sueldo);
            }

        }
    }
}
