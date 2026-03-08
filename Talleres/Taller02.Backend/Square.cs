
namespace Taller02.Backend;

public class Square: GeometricFigure
{
    private double _a;
    public Square(string name, double a): base(name)
    {
        A = a;
    }

    public double A 
    { 
        get => _a; 
        set => _a = ValidateA(value); 
    }

    public override double GetArea() => A * A;

    public override double GetPerimiter() => 4 * A;

    


    private double ValidateA(double a) 
    {
        if(a < 0)
        {
            throw new ArgumentException(nameof(a), "A must be gratest than 0");
        }
        return a;
    }
}
