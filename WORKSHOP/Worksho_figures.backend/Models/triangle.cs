namespace Worksho_figures.backend.Models;

public class Triangle : Parallelogram
{
    public double C { get; set; }
    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b, h)
    {
        C = c;
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
