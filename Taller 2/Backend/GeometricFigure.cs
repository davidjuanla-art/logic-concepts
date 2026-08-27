

namespace Backend_;

public abstract class GeometricFigure
{
    // Constructors
    protected GeometricFigure(String name)
    {
        this.name = name;
    }


    //properties
    public String name { get; set; } = null!;



    //method

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{name}\t => Area: {GetArea()}\t Perimeter: {GetPerimeter()}";




    }
}

