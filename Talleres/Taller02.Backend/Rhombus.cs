

namespace Taller02.Backend;

public class Rhombus : Square

   
{
    private decimal _d1;
    private decimal _d2;
    public Rhombus(string name,decimal a, decimal d1, decimal d2 ): 
        base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    public decimal D1 
    { 
        get => _d1; 
        set => _d1 = ValidateD1(value); 
    }

    public decimal D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }
    public override decimal GetArea() => (D1 * D1) / 2;


    public override decimal GetPerimiter() => 4 * A;
    

    private decimal ValidateD1(decimal d1)
    {
        if (d1 < 0)
        {
            throw new ArgumentException(nameof(d1), "D1 must be gratest than 0");
        }
        return d1;
    }

    private decimal ValidateD2(decimal d2)
    {
        if (d2 < 0)
        {
            throw new ArgumentException(nameof(d2), "D2 must be gratest than 0");
        }
        return d2;
    }
}
