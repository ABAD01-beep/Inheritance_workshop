namespace Worksho_figures.backend.Models;

public class Kite : Rhombus
{
    private double _b;

    public double B
    {
        get { return _b; }
        set { _b = ValidateB(value); }
    }

    public Kite(string name, double a, double b, double d1, double d2)
        : base(name, a, d1, d2)
    {
        B = b;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }
    private double ValidateB(double value)
    {
        if (value <= 0)
            throw new ArgumentException("B must be positive");
        return value;
    }
}
