using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
  int total = 0;
    for(int i = 0; i< marks.Length; i++)
    {
      total = total + marks[i];
    }
    return total / marks.Length;
  }
}