

using Shared;

var answer = string.Empty;
var options = new List<string> { "si", "no" };

do
{
    Console.Write("Ingrese un nombre: ");
String Name = Console.ReadLine();


var HoursWorked = ConsoleExtension.GetInt("Ingrese número de horas trabajadas: ");
var HourlyRate = ConsoleExtension.GetInt("Ingrese valor hora: ");
var MinimumSalary = ConsoleExtension.GetInt("Ingrese valor salario mínimo mensual: ");


var MonthlySalary = HoursWorked * HourlyRate;

if (MonthlySalary > MinimumSalary)
{ 
    Console.WriteLine($"nombre: {Name} ");
    Console.Write($"Salario mensual: {MonthlySalary} ");
}
else
{
    Console.WriteLine($"nombre: {Name} ");

    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar? si/no: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("si", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("game over");