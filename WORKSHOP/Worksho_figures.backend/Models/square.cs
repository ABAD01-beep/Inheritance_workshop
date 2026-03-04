namespace Worksho_figures.backend.Models;
public class Square : GeometricFigure
{
    public double A { get; set; }

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
}
