using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
public class LongestConsecutives 
{
    
    public static String LongestConsec(string[] strarr, int k) 
    {
        if(strarr.Length == 0 || k > strarr.Length || k <= 0) {
                return "";
            }
            string s = "";

            //Add length of strings to list
            List<int> lengthOfStrings = new List<int>();
            
            for (int i = 0; i < strarr.Length; i++)
            {
                lengthOfStrings.Add(strarr[i].Length);
            }
            
            List<int> lengths = new List<int>();
            for (int i = 0; i <= strarr.Length - k; i++)
            {
                int length = 0;
                for (int j = 0; j < k; j++)
                {
                    length = length + strarr[i+j].Length;
                }
                lengths.Add(length);

            }

            for (int i = 0; i < lengths.Count; i++)
            {
                System.Console.WriteLine(lengths[i]);
            }
            
            for (int i = 0; i < k; i++)
            {

                s = s + strarr[i+ lengths.IndexOf(lengths.Max())];

            }

            return s;
    }
}