
using Shared;

var answer = String.Empty;
var options = new List<string> { "s", "n" };

do 
{ 

    var x = ConsoleExtension.GetInt("Ingrese primer nùmero: ");
    var y = ConsoleExtension.GetInt("Ingrese segundo nùmero: ");
    var z = ConsoleExtension.GetInt("Ingrese tercer nùmero: ");


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

    
   answer = ConsoleExtension.GetValidOptions("¿Desea repetir? (s/n): ", options);

} while (answer != null && answer.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;