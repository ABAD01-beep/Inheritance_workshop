namespace Worksho_figures.backend.Models;

public class Rectangle : Square
{
    private double _b;

    public double B
    {
        get { return _b; }
        set { _b = ValidateB(value); }
    }

    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateB(double value)
    {
        if (value <= 0)
            throw new ArgumentException("B must be positive");
        return value;
    }
}
