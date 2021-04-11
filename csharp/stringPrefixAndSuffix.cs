using System;
using System.Collections.Generic;
using System.Linq;

public class SuffPref
{
    public static int solve(string s){  
        if (s.Length == 1)
            {
                return 0;
            }

            
            string[] prefArray = new string[s.Length/2];
            string[] sufArray = new string[s.Length/2];
            //add prefix and suffix strings to arrays
            for (int i = 0; i < s.Length/2; i++)
            {
                prefArray[i] = s.Substring(0, i+1);
                Console.WriteLine(prefArray[i]);

                sufArray[i] = s.Substring(s.Length - (i+1));
                Console.WriteLine(sufArray[i]);
            }
            //compare values in arrays and find longest common string
            //return the length of that string
            for (int i = prefArray.Length-1; i >= 0 ; i--)
            {
                if (prefArray[i] == sufArray[i])
                {
                    return sufArray[i].Length;
                }
            }
            return 0;
    }
}