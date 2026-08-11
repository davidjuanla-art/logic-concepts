
using Shared;


var x = ConsoleExtension.GetInt("Ingrese primer nùmero: ");
var y = ConsoleExtension.GetInt("Ingrese segundo nùmero: ");
var z = ConsoleExtension.GetInt("Ingrese tercer nùmero: ");

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
        Console.WriteLine($"El numero mayor es: {Mayor}, el del medio es: {Medio} y el menor es: {Menor}");
    }
    else if (y >= x && y >= z)
    {
        Mayor = y;

        if (z >= x) 
        {
        Medio = z;
        Menor = x;
            Console.WriteLine($"El numero mayor es: {Mayor}, el del medio es: {Medio} y el menor es: {Menor}");
        }
    }
    else
    {
        Mayor = z;

        if (y >= x)
        {
            Medio = y;
            Menor = x;
        }
        else
        {
            Medio = x;
            Menor = y;
        }
        Console.WriteLine($"El numero mayor es: {Mayor}, el del medio es: {Medio} y el menor es: {Menor}");
    }
    answer = ConsoleExtension.GetValidOptions("¿Desea repetir? (s/n): ", options);

} while (answer != null && answer.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;
}
   
