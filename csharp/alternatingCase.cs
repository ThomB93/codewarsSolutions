using System;
using System.Linq;
using System.Collections.Generic;

namespace Extensions
{
  public static class StringExt
  {
    public static string ToAlternatingCase (this string s)
    {
      int sCount = s.Count();
            Char[] cString = s.ToCharArray();
            List<char> cFinal = new List<char>();
            foreach (char c in cString)
            {
                if (char.IsUpper(c))
                    cFinal.Add(char.ToLower(c));
                else if (char.IsLower(c))
                    cFinal.Add(char.ToUpper(c));
                else
                    cFinal.Add(c);
            }
            char[] cArray = cFinal.ToArray();
            string final = new string(cArray);
            return final;
    }
  }
}