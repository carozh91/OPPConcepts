

namespace Taller02.Backend;

public class Trapeze:Triangle
{
    private decimal _d;
    
    public Trapeze(string name, decimal a, decimal b, decimal h, decimal c,decimal d) : base(name,a,b,h,c)
    {
        D = d;
    }

    public decimal D
    {
        get => _d;
        set => _d = ValidateD(value);
    }
    public override decimal GetArea() => (B + D) * H/2;


    public override decimal GetPerimiter() => (A + B + C + D);

    private decimal ValidateD(decimal d)
    {
        if (d < 0)
        {
            throw new ArgumentException(nameof(d), "D must be gratest than 0");
        }
        return d;
    }


}
