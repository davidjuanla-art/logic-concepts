public class Ruta
{
    private int numeroRuta;
    private int valorBase;

    public Ruta(int numeroRuta)
    {
        this.numeroRuta = numeroRuta;

 public class Ruta
    {
        private const int BASE_RUTA1 = 500000;
        private const int BASE_RUTA2 = 600000;
        private const int BASE_RUTA3 = 800000;
        private const int BASE_RUTA4 = 1000000;

        private int numeroRuta;

        public Ruta(int numeroRuta)
        {
            this.numeroRuta = numeroRuta;
        }

        public override string ToString()
        {
            return $"Ruta {numeroRuta}: {ObtenerBase()}";
        }

        private int ObtenerBase()
        {
            switch (numeroRuta)
            {
                case 1: return BASE_RUTA1;
                case 2: return BASE_RUTA2;
                case 3: return BASE_RUTA3;
                case 4: return BASE_RUTA4;
                default: throw new ArgumentException("Número de ruta inválido");
            }
        }

        public double CalcularComision(int pasajeros)
        {
            int valorBase = ObtenerBase();

            if (pasajeros < 50) return 0;

            switch (numeroRuta)
            {
                case 1:
                    if (pasajeros <= 100) return valorBase * 0.05;
                    else if (pasajeros <= 150) return valorBase * 0.06;
                    else if (pasajeros <= 200) return valorBase * 0.07;
                    else return valorBase * 0.07 + (pasajeros - 200) * 50;

                case 2:
                    if (pasajeros <= 100) return valorBase * 0.07;
                    else if (pasajeros <= 150) return valorBase * 0.08;
                    else if (pasajeros <= 200) return valorBase * 0.09;
                    else return valorBase * 0.09 + (pasajeros - 200) * 60;

                case 3:
                    if (pasajeros <= 100) return valorBase * 0.10;
                    else if (pasajeros <= 150) return valorBase * 0.13;
                    else if (pasajeros <= 200) return valorBase * 0.15;
                    else return valorBase * 0.15 + (pasajeros - 200) * 100;

                case 4:
                    if (pasajeros <= 100) return valorBase * 0.125;
                    else if (pasajeros <= 150) return valorBase * 0.15;
                    else if (pasajeros <= 200) return valorBase * 0.17;
                    else return valorBase * 0.17 + (pasajeros - 200) * 150;

                default:
                    throw new ArgumentException("Número de ruta inválido");
            }
        }
    }
