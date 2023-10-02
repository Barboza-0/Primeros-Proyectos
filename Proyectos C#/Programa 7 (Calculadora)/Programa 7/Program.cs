using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Numero: "); int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Operador: "); char operador = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Numero: "); int n2 = Convert.ToInt32(Console.ReadLine());
        int r = 0, a = 0;
        switch(operador)
        {
            case '+':
                r = n + n2;
                break;
            case '-':
                r = n - n2;
                break;
            case '*':
                r = n * n2;
                break;
            case '/':
                r = n / n2;
                break;
            default:
                Console.WriteLine("Operador invalido..");
                a = 1;
                break;
        }
        if(a == 0)
        {
            Console.WriteLine("El resultado es " + r);
        }
    }
}