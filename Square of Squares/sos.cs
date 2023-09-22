using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    if(n < 0) return false;
    double helpVar  = Math.Sqrt(n);
    if(helpVar % 1 == 0) return true;
    else return false;
  }
}
