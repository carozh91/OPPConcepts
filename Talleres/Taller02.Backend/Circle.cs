

namespace Taller02.Backend;

public class Circle: GeometricFigure
{
    private decimal _r;

    public Circle(string name, decimal r) :
        base(name)
    {
        R = r;
    }

    public decimal R 
    { 
        get => _r; 
        set => _r = ValidateR(value); 
    }

    public override decimal GetArea() => 3.1416m * R* R;


    public override decimal GetPerimiter() => 2 * 3.1416m * R;


    public override string ToString()
    {
        return base.ToString();
    }

    private decimal ValidateR(decimal r) 
    {
        if (r < 0) 
        {
            throw new ArgumentOutOfRangeException(nameof(r), "The radius must be gratest than 0");
        }
        return r;
    }


}
