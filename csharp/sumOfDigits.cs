using System;
using System.Collections.Generic;
using System.Linq;

public class Number
{
  public int DigitalRoot(long n)
  {
    string s = n.ToString();
            long result = 0; 
            //sum all digits in n
            for (int i = 0; i < s.Length; i++)
            {
                result = result + (long)Char.GetNumericValue(s[i]);
            }
            //if string length of the sum of all digits in n > 1, then sum all digits again

            if (result > 9)
            {
                result = (long)DigitalRoot(result);
            }
            return (int)result;
  }
}