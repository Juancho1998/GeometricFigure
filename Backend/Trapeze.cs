namespace Backend;

public class Trapeze : Triangle
{
    //Fields
    private double _d;
    //Constructors   
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        D = d;
    }
    //Propierties
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }
    //Public Methods

    public override double GetArea() => (B + D) * H / 2;

    public override double GetPerimeter() => A + B + C + D;
    //Private Methods
    private double ValidateD(double D)
    {
        if (D <= 0)
        {
            throw new Exception($"The area: {D}, cannot be less or equal zero.");
        }
        return D;
    }
}
