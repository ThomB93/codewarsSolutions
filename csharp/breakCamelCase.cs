using System;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    for(int i = 1; i < str.Length; i++) {
      if(Char.IsUpper(str[i]) && !Char.IsWhiteSpace(str[i-1])) {
        str = str.Insert(i, " ");
      }
    }
    return str;
  }
}