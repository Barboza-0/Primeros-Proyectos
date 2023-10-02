using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Ingrese un numero: "); int n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("El numero " + n + " es Par");
        }
        else
        {
            Console.WriteLine("El numero " + n + " es Impar");
        }
    }
}