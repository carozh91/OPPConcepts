

using System;

namespace Taller02.Backend;

public class Triangle:Rectangle
{
    private double _h;
    private double _c;
    public Triangle(string name, double a, double b, double h, double c) : base(name, a, b)
    {
        H = h;
        C = c;
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }


    public override double GetArea() => (H * B)/2;


    public override double GetPerimiter() => (A + B + C);

    private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new ArgumentException(nameof(h), "H must be gratest than 0");
        }
        return h;
    }

    private double ValidateC(double c)
    {
        if (c < 0)
        {
            throw new ArgumentException(nameof(c), "C must be gratest than 0");
        }
        return c;
    }
}
