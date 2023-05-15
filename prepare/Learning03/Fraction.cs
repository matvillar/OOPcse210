public class Fraction
{
  private int _top;
  private int _bottom;


public Fraction()
{
_top = 1;
_bottom = 1;
}
public Fraction(int number)
{
_top = number;
_bottom = 1;
}
public Fraction(int top, int bottom)
{
_top = top;
_bottom = bottom;
}

public string GetFractionString()
{
  return $"{_top}/{_bottom}";
}
public double GetFractionValue()
{
  double value = (double)_top / (double)_bottom;
  return Math.Round(value, 2);
}
public int Top
{
  get { return _top; } // read
  set { _top = value; }
}
public int Bottom
{
  get { return _bottom; }
  set { _bottom = value; }

}

}
