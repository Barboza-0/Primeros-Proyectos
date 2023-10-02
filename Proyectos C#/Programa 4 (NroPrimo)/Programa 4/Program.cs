using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Ingrese un numero: "); int n = Convert.ToInt32(Console.ReadLine());
        int contador = 0;

        for(int x = 1; x <= n; x++)
        {
            if(n % x == 0) contador++;
        }

        if(contador == 2)
        {
            Console.WriteLine("El numero " + n + " es primo");
        }
        else
        {
            Console.WriteLine("El numero " + n + " no es primo");
        }
    }
}