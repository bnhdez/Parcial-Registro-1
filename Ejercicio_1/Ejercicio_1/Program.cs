using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo, btc;
            
            Console.WriteLine("Ingrese su sueldo en dolares USD: ");
            sueldo = double.Parse(Console.ReadLine());

            btc = (sueldo * 0.000020);

            Console.WriteLine("Su sueldo en bitcoin es de: " + btc);
        }
    }
}
