using System;

public static class Kata
{
  public static string Leo(int oscar)
  {
    if (oscar == 88)
      return "Leo finally won the oscar! Leo is happy";
    else if (oscar == 86)
      return "Not even for Wolf of wallstreet?!";
    else if (oscar == 87 || oscar < 88 && oscar != 86)
      return "When will you give Leo an Oscar?";
    else if (oscar > 88)
      return "Leo got one already!";
    else return "";
  }
}