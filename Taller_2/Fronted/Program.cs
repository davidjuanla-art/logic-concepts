
using GeometricFigures.Backend;

var circle = new Circle(name: nameof(Circle), r: 5);
var square = new Square(name: nameof(Square), a: 10);


var figures = new List<GeometricFigure>
{
    circle, square, 
};

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}


