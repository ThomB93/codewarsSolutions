using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    string[] sArray = numbers.Split(' ');
            int[] calcNumbers = new int[sArray.Length];
            for (int i = 0; i < calcNumbers.Length; i++)
            {
                calcNumbers[i] = Convert.ToInt32(sArray[i]);
            }
            int max = calcNumbers.Max();
            int min = calcNumbers.Min();
            return max + " " + min;
  }
}