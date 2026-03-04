namespace Worksho_figures.backend.Models;
public class Kite : Rhombus
{
    public double B { get; set; }

    public Kite(string name, double a, double b, double d1, double d2)
        : base(name, a, d1, d2)
    {
        B = b;
    }
    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}
