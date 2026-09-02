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

    public abstract float GetArea();

    public abstract float GetPerimeter();

    public override string ToString() => $"{Name}\t\t => " + $"Area.....: {GetArea():N5}\t\t Perimeter.....: {GetPerimeter():N5}";

}
