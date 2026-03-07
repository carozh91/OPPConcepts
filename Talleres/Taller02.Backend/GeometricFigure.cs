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
        return $"{Name, -15}=> Area.....: {GetArea(),10:F5}\t\tPerimiter: {GetPerimiter(),10:F5}";
    }

    public abstract decimal GetArea();

    public abstract decimal GetPerimiter();
    
}
