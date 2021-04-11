using System;

public class Kata
{
  public static long FindNextSquare(long num)
  {
    double integerCheck = Math.Sqrt(num);
            if (integerCheck % 1 == 0)
              {
                  integerCheck = integerCheck + 1;
                  return (long)(integerCheck * integerCheck);
              }
              else
                {
                  integerCheck = -1;
                  return (long)integerCheck;
              };
  }
}