using System;

public class NthSeries {
  
  public static string seriesSum (int n)
  {
    string output = "";
    double sum = 1;
    float fractionNo = 4;
    if (n == 0)
    {
      output = "0.00";
      return output;
    }
    else if (n == 1)
    {
      output = "1.00";
      return output;
    }
    else if (n > 1)
    {
      while(n > 1)
      {
        sum = sum + (1/fractionNo);
        fractionNo = fractionNo + 3;
        n = n - 1;
      }
      return sum.ToString("F");
    }
    else
      return output;
  }
}