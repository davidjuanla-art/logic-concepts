using System;
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número límite: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Primos entre 0 y {n}:");
        for (int i = 0; i <= n; i++)
        {
            if (EsPrimo(i))
                Console.WriteLine(i);
        }
    }

    public static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        int limite = (int)Math.Sqrt(numero);

        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}
