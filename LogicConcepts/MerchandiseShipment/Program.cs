using Shared;

var weightOfMerchandise = ConsoleExtension.GetInt("Ingrese el peso de la mercancía");

double totalCost = 0;
double discount = 0;

if (weightOfMerchandise < 100)
{
    totalCost = 20000;
}
else if (weightOfMerchandise >= 100 && weightOfMerchandise <= 150)
{
    totalCost = 25000;
}
else if (weightOfMerchandise > 150 && weightOfMerchandise <= 200)
{
    totalCost = 30000;
}
else
{
    var additionalWeight = weightOfMerchandise - 200;
    var additionalCost = (additionalWeight / 10) * 2000;
    totalCost = 35000 + additionalCost;
}

if (totalCost >= 300000 && totalCost <= 600000)
{
    discount = totalCost * 0.10;
}
else if (totalCost > 600000 && totalCost <= 1000000)
{
    discount = totalCost * 0.20;
}
else if (totalCost > 1000000)
{
    discount = totalCost * 0.30;
}


Console.WriteLine("¿Es lunes? (si/no)");
string answerDay = Console.ReadLine().ToLower();

Console.WriteLine("¿Tipo de pago? (e/t)");
string answerPay = Console.ReadLine().ToLower();

if (answerDay == "si" && answerPay == "t")
{
    discount = totalCost * 0.5;
}
else if (answerPay == "e" && totalCost > 1000000)
{
    
    discount = totalCost * 0.4;
}

Console.WriteLine($"Tarifa {totalCost}");

if (discount > 0)
{
    Console.WriteLine($"ptomociòn {discount}");
    Console.WriteLine($"Total a pagar {totalCost - discount} ");
}

