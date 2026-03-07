

namespace Taller02.Backend;

public class Triangle:Rectangle
{
    private decimal _h;
    private decimal _c;
    public Triangle(string name, decimal a, decimal b, decimal h,decimal c) : base(name, a, b)
    {
        H = h;
        C = c;
    }

    public decimal H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public decimal C
    {
        get => _c;
        set => _c = ValidateC(value);
    }


    public override decimal GetArea() => (H * B)/2;


    public override decimal GetPerimiter() => (A + B + C);

    private decimal ValidateH(decimal h)
    {
        if (h < 0)
        {
            throw new ArgumentException(nameof(h), "H must be gratest than 0");
        }
        return h;
    }

    private decimal ValidateC(decimal c)
    {
        if (c < 0)
        {
            throw new ArgumentException(nameof(c), "C must be gratest than 0");
        }
        return c;
    }
}
