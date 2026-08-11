
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{

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
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar? si/no: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("game over");
