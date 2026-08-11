

using Shared;

var answer = string.Empty;
var options = new List<string> { "si", "no" };

do
{

        var year = ConsoleExtension.GetInt("Ingrese un año: ");

    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    {
        Console.WriteLine($"El año {year} es bisiesto");
    }
    else
    {
        Console.WriteLine($"El año {year} no es bisiesto");
               
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar? si/no: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("si", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("game over");