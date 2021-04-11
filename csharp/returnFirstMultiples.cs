public class Kata
{
  public static double[] Multiples(int m, double n)
  {
    double[] multiples = new double[m];
            double startN = n;
            for (int i = 0; i < m; i++)
            {
                multiples[i] = n;
                n = n + startN;
            }
            return multiples;
  }
}