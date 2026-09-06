namespace Backend;

public class Rhombus : Square
{
    //Fields
    private int _d1;
    private int _d2;

    //Constructors
    public Rhombus(string name, int a, int d1, int d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }
    //Propierties
    public int D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }
    public int D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }

    //Public Methods
    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 4 * A;


    //Private Methods
    private int ValidateD1(int D1)
    {
        if (D1 <= 0)
        {
            throw new Exception($"The value: {D1}, cannot be less or equal zero.");
        }
        return D1;
    }
    private int ValidateD2(int D2)
    {
        if (D2 <= 0)
        {
            throw new Exception($"The value: {D2}, cannot be less or equal zero.");
        }
        return D2;
    }
}
