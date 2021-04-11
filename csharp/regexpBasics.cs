using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata
{
    public static bool Digit(this string s)
    {
        string[] array = new string[10];
        for (int i = 0;i<array.Length ;i++ ) {
          array[i] = i.ToString();
          if (s == array[i]) {
            return true;
          }       
        }
        return false;
    }
}