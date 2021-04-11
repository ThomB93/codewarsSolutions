using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
  public string Pattern(int n)
  {
    string s = "";
            if (n < 1)
                return s;
            else if (n == 1)
                return "1";
            else
            {
                for (int i = 1; i < n; i++)
                {
                    s = s + string.Join("", Enumerable.Repeat(Convert.ToString(i), i)) + Environment.NewLine;
                }
                s = s + string.Join("", Enumerable.Repeat(Convert.ToString(n), n));
            }
            return s;   
  }
}