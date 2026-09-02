namespace Backend
{
    public class Circle : GeometricFigure
    {
        //Fields
        private int _r;

        //Constructors
        public Circle(string name, int r) : base(name)
        {
            R = r;
        }

        //Propierties
        public int R
        {
            get => _r;
            set => _r = ValidateR(value);
        }


        //Public Methods
        public override float GetArea() => (float)Math.PI * (float)Math.Pow(R, 2);

        public override float GetPerimeter() => 2 * (float)Math.PI * R;

        //Private Methods

        private int ValidateR(int R)
        {
            if (R < 0)
            {
                throw new Exception($"The radius: {R}, cannot be less zero.");
            }
            return R;
        }

    }
}
