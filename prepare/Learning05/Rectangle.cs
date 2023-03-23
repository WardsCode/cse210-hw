using System;

public class Rectangle : Shape
{
    private int _large;
    private int _wide;

    public Rectangle (int large, int wide, string color) : base(color)
    {
        _large = large;
        _wide = wide;
    }

    public override double GetArea()
    {
        return _large * _wide;
    }
}