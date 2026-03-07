

namespace Taller02.Backend;

public class Rectangle : Square
{
    private decimal _b;
    public Rectangle(string name, decimal a, decimal b): base(name,a)
    {
        B = b;
    }

    public decimal B
    {
        get => _b;
        set => _b = ValidateB(value);
    }
    public override decimal GetArea() => A * B;


    public override decimal GetPerimiter() => 2 * (A + B);

    private decimal ValidateB(decimal b)
    {
        if (b < 0)
        {
            throw new ArgumentException(nameof(b), "B must be gratest than 0");
        }
        return b;
    }
}
