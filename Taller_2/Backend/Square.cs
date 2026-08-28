

namespace GeometricFigures.Backend;

   public class Square : GeometricFigure
    {
        //fields

        private double _a;

        //consteuctors

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        //properties

        public double A { 
        get => _a; 
        set => _a = ValidateA(value); 
        }

        // public methods

        public override double GetArea()
        {
            return  _a * _a;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }
    private double ValidateA(double A)
    {
        if (A <= 0)
        {
            throw new Exception($"El lado {A} debe ser mayor a cero");
        }
        return A;
    }
}
    



