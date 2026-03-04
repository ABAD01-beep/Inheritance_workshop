namespace Worksho_figures.backend.Models;
public class Rectangle : Square
{
    public double B { get; set; }
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
}
