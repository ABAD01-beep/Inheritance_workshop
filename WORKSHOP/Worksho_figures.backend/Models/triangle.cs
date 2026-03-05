namespace Worksho_figures.backend.Models;

public class Triangle : Rectangle
{
    public double c;
    public double h;
    public double C
    {
        get { return c; }
        set
        {
            c = value;
            ValidateC();
        }
    }

    public double H
    {
        get { return h; }
        set
        {
            h = value;
            ValidateH();
        }
    }

    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        C = c;
        H = h;
        ValidateC();
        ValidateH();

    }

    private void ValidateC()
    {
        if (C <= 0)
            throw new ArgumentException("Side C must be greater than zero.");
    }

    private void ValidateH()
    {
        if (H <= 0)
            throw new ArgumentException("Height must be greater than zero.");
    }
    public override double GetArea()
    {
        return (B * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }
}
