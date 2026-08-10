
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{

    var number = ConsoleExtension.GetInt("Ingrese un nùmero o control + c para salir");




    if (number % 2 == 0)
    {
        Console.WriteLine($"el nùmero {number} es par");
    }
    else
    {
        Console.WriteLine($"el nùmero  {number} es impar");

    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar? si/no: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("game over");

