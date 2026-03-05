namespace Worksho_figures.backend.Models;

public class Square : GeometricFigure
{
    private double _a;

    public double A
    {
        get { return _a; }
        set { _a = ValidateA(value); }
    }
    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }
    private double ValidateA(double value)
    {
        if (value <= 0)
            throw new ArgumentException("A must be positive");
        return value;
    }
}
