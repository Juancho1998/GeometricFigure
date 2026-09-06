namespace Backend;

public class Square : GeometricFigure
{

    //Fields
    private double _a;

    //Constructors
    public Square(string name, double a) : base(name)
    {
        A = a;
    }
    //Propierties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }
    //Public Methods
    public override double GetArea() => (float)Math.Pow(A, 2);

    public override double GetPerimeter() => 4 * (float)A;
  
    //Private Methods
    private double ValidateA(double A)
    {
        if (A <= 0)
        {
            throw new Exception($"The value: {A}, cannot be less or equal zero.");
        }
        return A;
    }
}
