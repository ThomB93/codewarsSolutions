using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    List<int> aList = a.ToList();
            List<int> bList = b.ToList();

            var difference = aList.Where(a1 => !bList.Any(b1 => b1 == a1)).ToList();

            return difference.ToArray();
  }
}