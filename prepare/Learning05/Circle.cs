using System;

public class Circle : Shape
{
    private int _radio;

    public Circle (int radio, string color) : base(color)
    {
        _radio = radio;
    }

    public override double GetArea()
    {
        return 3.141516 * (_radio * _radio);
    }
}