using Backend;


var circle = new Circle(name: nameof(Circle), r: 5);
var square = new Square(name: nameof(Square), a: 10);
var rhombus = new Rhombus(name: nameof(Rhombus), a: 5, d1: 7, d2: 10);

var figures = new List<GeometricFigure>
{
circle, square, rhombus
};
foreach (var figure in figures)
{
    Console.WriteLine(figure);
}
