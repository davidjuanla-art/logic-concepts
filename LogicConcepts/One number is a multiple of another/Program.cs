
using Shared;


var x = ConsoleExtension.GetInt("Ingrese primer nùmero: ");
var y = ConsoleExtension.GetInt("Ingrese segundo nùmero: ");




if (x % y == 0)
{ 
    Console.WriteLine($"El nùmero {y} es múltiplo de {x}");
}
else
{
    Console.WriteLine($"El nùmero {y} no es múltiplo de {x}");
}
