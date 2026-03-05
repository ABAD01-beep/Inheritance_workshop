namespace Worksho_figures.backend.Models
{
    public interface IRectangle
    {
        double B { get; set; }

        double GetArea();
        double GetPerimeter();
    }
}