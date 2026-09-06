namespace Backend;

public class Parallelogram : Rectangle
{
    //Fields
    private double _h;
    //Constructors
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //Propierties
    //Public Methods
    public override double GetArea() => B * H;

    public override double GetPerimeter() => 2 * (A + B);
    //Private Methods
    private double ValidateH(double H)
    {
        if (H <= 0)
        {
            throw new Exception($"The area: {H}, cannot be less or equal zero.");
        }
        return H;
    }


}
