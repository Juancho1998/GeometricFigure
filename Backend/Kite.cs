namespace Backend;

public class Kite : Rhombus
{

    //Fields
    private int _b;
    //Constructor
    public Kite(string name, int a, int b, int d1, int d2) : base(name, a, d1, d2)
    {
        B = b;
    }

    //Propierties
    public int B
    {
        get => _b;
        set => _b = ValidateB(value);
    }
    //Public Methods
    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 2 * (A + B);
    //Private Methods
    private int ValidateB(int B)
    {
        if (B <= 0)
        {
            throw new Exception($"The value: {B}, cannot be less or equal zero.");
        }
        return B;
    }
}
