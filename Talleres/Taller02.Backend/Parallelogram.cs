

namespace Taller02.Backend;

public class Parallelogram: Rectangle
{
    private double _h;
    public Parallelogram(string name, double a, double b, double h) : base(name, a,b)
    {
        H = h;
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }
    public override double GetArea() => H * B;


    public override double GetPerimiter() => 2 * (A + B);

    private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new ArgumentException(nameof(h), "H must be gratest than 0");
        }
        return h;
    }
}
