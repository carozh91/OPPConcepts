

namespace Taller02.Backend;

public class Parallelogram: Rectangle
{
    private decimal _h;
    public Parallelogram(string name, decimal a, decimal b, decimal h) : base(name, a,b)
    {
        h = _h;
    }

    public decimal H
    {
        get => _h;
        set => _h = ValidateH(value);
    }
    public override decimal GetArea() => H * B;


    public override decimal GetPerimiter() => 2 * (A + B);

    private decimal ValidateH(decimal h)
    {
        if (h < 0)
        {
            throw new ArgumentException(nameof(h), "B must be gratest than 0");
        }
        return h;
    }
}
