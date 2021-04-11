using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    //find index of all words with length > 4
            string[] words = sentence.Split(" ");
            List<string> WordList = new List<string>();
            foreach (var item in words)
            {
                if(item.Length > 4)
                {
                    char[] charArray = item.ToCharArray();
                    Array.Reverse(charArray);
                    WordList.Add(new string(charArray));
                } else {
                    WordList.Add(item);
                }
            }

            return string.Join(" ",WordList);
  }
}