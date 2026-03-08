namespace Taller02.Backend;

public abstract class GeometricFigure
{
    public GeometricFigure(string name)
    {
        Name = name;
    }
    public string Name { get; set; } = null!;

    public override string ToString()
    {
        return $"{Name, -15}=> Area.....: {GetArea(),12:N5}    Perimiter: {GetPerimiter(),12:N5}";
    }

    public abstract double GetArea();

    public abstract double GetPerimiter();
    
}
