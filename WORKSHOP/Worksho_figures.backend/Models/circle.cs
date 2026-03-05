using Worksho_figures.backend.Models;

public class Circle : GeometricFigure
{
    private double _r;

    public double R
    {
        get { return _r; }
        set { _r = ValidateR(value); }
    }

    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    public override double GetArea()
    {
        return Math.PI * R * R;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    private double ValidateR(double value)
    {
        if (value <= 0)
            throw new ArgumentException("R must be positive");
        return value;
    }
}