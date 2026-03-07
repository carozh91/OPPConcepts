
namespace Taller02.Backend;

public class Square: GeometricFigure
{
    private decimal _a;
    public Square(string Name, decimal a): base(Name)
    {
        A = a;
    }

    public decimal A 
    { 
        get => _a; 
        set => _a = ValidateA(value); 
    }

    public override decimal GetArea() => A * A;

    public override decimal GetPerimiter() => 4 * A;

    public override string ToString()
    {
        return base.ToString();
    }


    private decimal ValidateA(decimal a) 
    {
        if(a < 0)
        {
            throw new ArgumentException(nameof(a), "A must be gratest than 0");
        }
        return a;
    }
}
