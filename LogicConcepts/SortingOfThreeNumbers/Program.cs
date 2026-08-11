
using Shared;

var options = new List<string> { "s", "n" };
string? answer;

do
{
    var x = ConsoleExtension.GetInt("Ingrese primer número: ");
    var y = ConsoleExtension.GetInt("Ingrese segundo número: ");
    var z = ConsoleExtension.GetInt("Ingrese tercer número: ");

    int Mayor = 0;
    int Medio = 0;
    int Menor = 0;

    if (x >= y && x >= z)
    {
        Mayor = x;
        if (y >= z)
        {
            Medio = y;
            Menor = z;
        }
        else
        {
            Medio = z;
            Menor = y;
        }
    }
    else if (y >= x && y >= z)
    {
        Mayor = y;
        if (x >= z)
        {
            Medio = x;
            Menor = z;
        }
        else
        {
            Medio = z;
            Menor = x;
        }
    }
    else
    {
        Mayor = z;
        if (x >= y)
        {
            Medio = x;
            Menor = y;
        }
        else
        {
            Medio = y;
            Menor = x;
        }
    }

    Console.WriteLine($"El número mayor es: {Mayor}, el del medio es: {Medio} y el menor es: {Menor}");

    answer = ConsoleExtension.GetValidOptions("¿Desea repetir? (s/n): ", options);

} while (answer != null && answer.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game over");

