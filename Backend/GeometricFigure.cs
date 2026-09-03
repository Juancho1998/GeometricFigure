namespace Backend;

public abstract class GeometricFigure
{

    //Constructors
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    //Propierties

    public string Name { get; set; }


    //Public Methods

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString() => $"{Name}\t\t => " + $"Area.....: {GetArea(),10:N5}  Perimeter.....: {GetPerimeter(),10:N5}";

}
