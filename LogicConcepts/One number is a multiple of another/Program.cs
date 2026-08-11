
using Shared;


var x = ConsoleExtension.GetInt("Ingrese primer nùmero: ");
var y = ConsoleExtension.GetInt("Ingrese segundo nùmero: ");




if (x % y == 0)
{
    Console.WriteLine($"El número {x} es múltiplo de {y}");
}
else
{
    Console.WriteLine($"El número {x} no es múltiplo de {y}");
}
