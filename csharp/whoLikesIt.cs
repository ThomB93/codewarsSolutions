using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    string output = "";
            switch (name.Length)
            {
                case 0:
                    output = "no one likes this";
                    break;
                case 1:
                    output = name[0] + " likes this";
                    break;
                case 2:
                    output = name[0] + " and " + name[1] + " like this";
                    break;
                case 3:
                    output = name[0] + ", " + name[1] + " and " + name[2] + " like this";
                    break;
                default:
                    break;
            }

            if(name.Length >= 4) {
                output = name[0] + ", " + name[1] + " and " + (name.Length-2).ToString() + " others like this";
            }

            return output;
  }
}