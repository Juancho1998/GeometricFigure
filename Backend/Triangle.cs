namespace Backend;

public class Triangle : Rectangle
{
    //Fields
    private double _c;
    private double _h;
    //Constructors
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    //Propierties
    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //Public Methods
    public override double GetArea() => (B * H) / 2;

    public override double GetPerimeter() => A + B + C;

    //Private Methods

    private double ValidateC(double C)
    {
        if (C <= 0)
        {
            throw new Exception($"The area: {C}, cannot be less zero.");
        }
        return C;
    }
    private double ValidateH(double H)
    {
        if (H <= 0)
        {
            throw new Exception($"The area: {H}, cannot be less zero.");
        }
        return H;
    }

}
