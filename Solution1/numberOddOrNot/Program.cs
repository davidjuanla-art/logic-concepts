do
{
    Console.WriteLine("Ingrese un nùmero o control + c para salir");

var numero = Console.ReadLine();
var numeroInt = int.Parse(numero!);


    if (numeroInt % 2 == 0) {
        Console.WriteLine($"el nùmero { numeroInt} es par");
    } else {
        Console.WriteLine($"el nùmero  {numeroInt} es impar");

    }

} while (true) ;
