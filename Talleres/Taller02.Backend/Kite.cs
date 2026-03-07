

namespace Taller02.Backend;

public class Kite : Rhombus

    
{
    private decimal _b;
    public Kite(string name, decimal a, decimal d1, decimal d2, decimal b): base(name,a,d1,d2)
    {
        B = b;
    }

    public decimal B 
    { 
        get => _b; 
        set => _b = ValidateB(value); 
    }
    public override decimal GetArea() => (D1 * D2) / 2;


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
