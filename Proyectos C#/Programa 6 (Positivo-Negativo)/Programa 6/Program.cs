using System;

class principal
{
    static void Main()
    {
        Console.WriteLine("Ingrese un numero: "); int n = Convert.ToInt32(Console.ReadLine());

        if(n > 0)
        {
            Console.WriteLine(n + " es un numero positivo");
        }
        else
        {
            if(n < 0)
            {
                Console.WriteLine(n + " es un numero negativo");
            }
            else
            {
                Console.WriteLine(n + " es cero");
            }
        }
    }
}