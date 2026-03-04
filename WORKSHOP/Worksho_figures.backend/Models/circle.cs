namespace Worksho_figures.backend.Models;
public class Circle : GeometricFigure
{
    public double R { get; set; }
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
}