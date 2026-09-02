namespace Backend;

public class Square : GeometricFigure
{

    //Fields
    private int _a;

    //Constructors
    public Square(string name, int a) : base(name)
    {
        A = a;
    }
    //Propierties
    public int A
    {
        get => _a;
        set => _a = ValidateA(value);
    }
    //Public Methods
    public override float GetArea() => (float)Math.Pow(A, 2);

    public override float GetPerimeter() => 4 * A;
  
    //Private Methods
    private int ValidateA(int A)
    {
        if (A < 0)
        {
            throw new Exception($"The area: {A}, cannot be less zero.");
        }
        return A;
    }
}
