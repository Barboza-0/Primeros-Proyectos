using System;

namespace Base
{
    class Entrada
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un numero: "); int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: "); int n2 = Convert.ToInt32(Console.ReadLine());

            int r = n * n2;
            Console.WriteLine("El resultado es " + r);
        }
    }
}
