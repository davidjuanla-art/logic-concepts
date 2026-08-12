

using Shared;

var answer = string.Empty;
var options = new List<string> { "si", "no" };

do
{
    var  quantity= ConsoleExtension.GetInt("Nùmero de escritorios comprados: ");
var unitPrice = 650000;

double totalPrice = quantity * unitPrice;
double total = 0;

    if (quantity < 5)
{
    total = totalPrice - (totalPrice * 0.10) ;

    Console.WriteLine($"El valor apagar es {total}");
}
else if (quantity >= 5 && quantity < 10)
{
    total = totalPrice - (totalPrice * 0.20);
    Console.WriteLine($"El valor apagar es {total}");
}
else if (quantity >= 10)
{
    total = totalPrice - (totalPrice * 0.40);
    Console.WriteLine($"El valor apagar es {total}");
}
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar? si/no: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("si", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("game over");