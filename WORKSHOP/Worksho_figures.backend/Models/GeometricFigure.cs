
namespace Worksho_figures.backend.Models;

public abstract class GeometricFigure
{
    private string name;

    public string Name
    {
        get { return name; }
    }

    protected GeometricFigure(string name)
    {
        this.name = name;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),10:N5}   Perimeter: {GetPerimeter(),10:N5}";
    }
}