using System;

public class Kata
{
  public static int CountBits(int n)
  {
    string binary = Convert.ToString(n, 2);
            int counter = 0;
            foreach (char digit in binary)
            {
                if (digit == '1')
                {
                    counter++;
                }
            }

            return counter;
  }
}