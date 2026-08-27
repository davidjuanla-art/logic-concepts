namespace Backend_;

public class Circle : GeometricFigure

    {
        // fields

        private double _r;

    //constructor

    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    //properties

    public double R
    { get => _r; 
        set => _r = ValidateR(value); 
    }

    // public methods 


    public override double GetArea()
    {
        return Math.PI * _r * _r;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * _r;
    }

    //private methods

    private double ValidateR(double value)
    {
       if (R  <= 0)
        {
            throw new Exception($"El radio {R} debe ser mayor a cero");
        }
        return R;
    }
}



