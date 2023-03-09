using System;

public class Fraction
{
    private int _top;               /*member attributes (variables)*/
    private int _bottom;            /*member attributes (variables)*/

    public Fraction()                          /*constructor #1, no parameters*/
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholenumber)           /*constructor #2, 1 parameter (top number)*/
    {
        _top = wholenumber;
        _bottom = 1;
    }

       public Fraction(int top, int bottom)     /*constructor #3, 2 parameters*/
    {
        _top = top;
        _bottom = bottom;
    }

    public void getTop(int topNumber)           /* getter for the top number*/
    {
        _top = topNumber;
    }

    public void getBottom(int bottomNumber)     /*getter for the bottom number*/
    {
        _bottom = bottomNumber;
    }

    public string GetFractionString()           /* to string a fraction 3/4*/
        {   
            string stringFraction = _top + "/" + _bottom;
            return stringFraction;
        }

    public double GetDecimalValue()             /*to crear a decimal*/
    {
        double divition = (double)_top / (double)_bottom;
        return divition;
    }
    



}