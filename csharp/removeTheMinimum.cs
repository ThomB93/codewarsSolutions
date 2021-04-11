using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    if (numbers.Count == 0)
      return new List<int>();
    else if (numbers.Count != 0)
    {
      int min = numbers.Min();
      numbers.Remove(min);
      return numbers;
    }
    else return numbers;
  }
}