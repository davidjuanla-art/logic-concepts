class Program
{
    static void Main(string[] args)
    {
        // Solo pasas el número de ruta
        Ruta miRuta = new Ruta(2); // Ruta 2

        Console.WriteLine(miRuta.ToString());

        Console.WriteLine("Ingrese número de pasajeros:");
        int pasajeros = int.Parse(Console.ReadLine());

        double comision = miRuta.CalcularComision(pasajeros);
        Console.WriteLine($"Comisión Ruta {2} con {pasajeros} pasajeros: {comision}");
    }
}
