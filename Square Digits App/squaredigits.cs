using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string final_string = "";
    string s = n.ToString();
    for(int i = 0; i < s.Length; i++) {
      char c = s[i];
      int help_var = (int)Char.GetNumericValue(c);
      double temp_result = Math.Pow(help_var, 2);
      final_string += temp_result.ToString();
    }
    
    Console.WriteLine(final_string);
    
    n = int.Parse(final_string);
    return n;
  }
}
