using System;
using System.Numerics;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      Console.WriteLine(a);
            Console.WriteLine(b);
            BigInteger sum = 0;
            if (a == "")
            {
                return b;
            }

            if (b == "")
            {
                return a;
            }
            BigInteger x = BigInteger.Parse(a);
            BigInteger y = BigInteger.Parse(b);
            sum = x + y;
            return sum.ToString();
    }
}