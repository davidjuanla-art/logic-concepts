using Shared;

var answer = string.Empty;
var options = new List<string> { "si", "no" };

do
{

    var NumeroCreditos = ConsoleExtension.GetInt("¿Cuál es el número de créditos?: ");
        var Estrato = ConsoleExtension.GetInt("¿Cuál es el estrato del estudiante?: ");
        var ValorCreditos = ConsoleExtension.GetInt("¿Cuál es el valor de cada crédito?: ");

        double TotalMatricula;
        double Subsidio = 0;

        
        if (NumeroCreditos <= 20)
        {
            TotalMatricula = NumeroCreditos * ValorCreditos;
        }
        else
        {
            TotalMatricula = (20 * ValorCreditos) + ((NumeroCreditos - 20) * ValorCreditos * 2);
        }

        if (Estrato == 1)
        {
            TotalMatricula -= TotalMatricula * 0.8; 
            Subsidio = 200000;
        }
        else if (Estrato == 2)
        {
            TotalMatricula -= TotalMatricula * 0.5; 
            Subsidio = 100000;
        }
        else if (Estrato == 3)
        {
            TotalMatricula -= TotalMatricula * 0.3; 
        }
      
        Console.WriteLine($"El valor de la matrícula es: {TotalMatricula}");
        if (Subsidio > 0)
        {
            Console.WriteLine($"El estudiante recibe un subsidio de: {Subsidio}");
        }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar? si/no: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("si", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("game over");


