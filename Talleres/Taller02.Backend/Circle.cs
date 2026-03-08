

namespace Taller02.Backend;

public class Circle: GeometricFigure
{
    private double _r;

    public Circle(string name, double r) :
        base(name)
    {
        R = r;
    }

    public double R 
    { 
        get => _r; 
        set => _r = ValidateR(value); 
    }

    public override double GetArea() => 3.1416 * R* R;


    public override double GetPerimiter() => 2 * 3.1416 * R;




    private double ValidateR(double r) 
    {
        if (r < 0) 
        {
            throw new ArgumentOutOfRangeException(nameof(r), "The radius must be gratest than 0");
        }
        return r;
    }


}
