

namespace Taller02.Backend;

public class Trapeze:Triangle
{
    private double _d;
    
    public Trapeze(string name, double a, double b, double h, double c, double d) : base(name,a,b,h,c)
    {
        D = d;
    }

    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }
    public override double GetArea() => (B + D) * H/2;


    public override double GetPerimiter() => (A + B + C + D);

    private double ValidateD(double d)
    {
        if (d < 0)
        {
            throw new ArgumentException(nameof(d), "D must be gratest than 0");
        }
        return d;
    }


}
