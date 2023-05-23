public class Fraction
{
  private int _top;
  private int _bottom;


public Fraction()
{
Top = 1;
Bottom = 1;
}
public Fraction(int number)
{
Top = number;
Bottom = 1;
}
public Fraction(int top, int bottom)
{
Top = top;
Bottom = bottom;
}

public string GetFractionString()
{
  return $"{Top}/{Bottom}";
}
public double GetFractionValue()
{
  double value = (double)Top / (double)Bottom;
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
