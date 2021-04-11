using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string PigIt(string str)
  {
    //find index of all words with length > 4
            string[] words = str.Split(" ");
            List<string> WordList = new List<string>();
            foreach (var item in words)
            {
                string s = item;
                string firstLetter =s[0].ToString();
                s = s.Remove(0, 1);
                s = s + firstLetter + "ay";
                WordList.Add(s);
            }

            return string.Join(" ", WordList);
  }
}