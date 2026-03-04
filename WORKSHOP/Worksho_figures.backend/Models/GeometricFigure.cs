
namespace Worksho_figures.backend.Models;
public abstract class GeometricFigure
{
    public string Name { get; set; }
    protected GeometricFigure(string name)
    {
        Name = name;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),10:N5}   Perimeter: {GetPerimeter(),10:N5}";
    }
}