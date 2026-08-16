using System;

Console.WriteLine("Ingrese el costo de compra del producto: ");
double cc = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el tipo de producto. p = perecedero, n = no perecedero: ");
string tp = Console.ReadLine().ToLower();

Console.WriteLine("Ingrese el tipo de conservación. f = frio, a = ambiente: ");
string tc = Console.ReadLine().ToLower();

Console.WriteLine("Ingrese el periodo de conservacion: ");
double pc = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el periodo de almacenamiento: ");
double pa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el volumen en litros: ");
double vol = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el medio de almacenamiento. n = nevera, c = congelador, e = estanteria, g = guacal: ");
string ma = Console.ReadLine().ToLower();



double ca = 0.0;

if (tp == "p")
{
    if (tc == "f" && pc < 10)
    {
        ca = cc * 0.05;
    }
    else if (tc == "f" && pc >= 10)
    {
        ca = cc * 0.10;
    }
    else if (tc == "a" && pa < 20)
    {
        ca = cc * 0.03;
    }
    else if (tc == "a" && pa > 20)
    {
        ca = cc * 0.10;
    }
    else if (tc == "a" && pa == 20)
    {
        ca = cc * 0.05;
    }
}
else if (tp == "n")
{
    if (vol >= 50)
    {
        ca = cc * 0.10;
    }
    else if (vol < 50)
    {
        ca = cc * 0.20;
    }
}



double pdp = 0.0;

if (pa < 30)
{
    pdp = 0.95;
}
else if (pa >= 30)
{
    pdp = 0.85;
}




double ce = 0.0;

if (tp == "p")
{
    if (tc == "f" && ma == "n")
    {
        ce = ca * 2;
    }
    else if (tc == "f" && ma == "c")
    {
        ce = ca;
    }
}
else if (tp == "n")
{
    if (ma == "e")
    {
        ce = ca * 0.05;
    }
    else if (ma == "g")
    {
        ce = ca * 0.07;
    }
}




double vrp = (cc + ca + ce) * pdp;




double vrv = 0.0;

if (tp == "p")
{
    vrv = vrp * 1.40;
}
else if (tp == "n")
{
    vrv = vrp * 1.20;
}





Console.WriteLine("Costo de almacenamiento: " + ca);
Console.WriteLine("Porcentaje de depreciacion: " + pdp);
Console.WriteLine("Costo de exhibicion: " + ce);
Console.WriteLine("Valor del producto: " + vrp);
Console.WriteLine("Valor de venta: " + vrv);

