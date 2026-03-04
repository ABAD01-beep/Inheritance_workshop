namespace Worksho_figures.backend.Models;
public class Rhombus : Square
{
    public double D1 { get; set; }
    public double D2 { get; set; }
    public Rhombus(string name, double a, double d1, double d2)
        : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }
    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }
}
