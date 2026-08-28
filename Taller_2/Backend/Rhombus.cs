

namespace GeometricFigures.Backend;

    public class Rhombus : Square

    {
        //fields

        private double _d1;
        private double _d2;

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    public double D1 { get => _d1; set => _d1 = value; }
    public double D2 { get => _d2; set => _d2 = value; }
}
