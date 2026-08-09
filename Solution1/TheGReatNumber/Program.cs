using Shared;

var  x = ConsoleExtension.GetInt("Ingrese primer nùmero: ");
var y = ConsoleExtension.GetInt("Ingrese segundo nùmero: ");
var z = ConsoleExtension.GetInt("Ingrese tercer nùmero: ");


do
{
    if (x >= y && x >= z)
    {
        Console.WriteLine($"El nùmero mayor es: {x}");
    }
    else if (y >= x && y >= z)
    {
        Console.WriteLine($"El nùmero mayor es: {y}");
    }
    else
            {
        Console.WriteLine($"El nùmero mayor es: {z}");
    }
} while (true);

