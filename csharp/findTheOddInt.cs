using System;
using System.Collections.Generic;
namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
          //create dictionary with numbers as keys, and the number of times they appear as values
            //loop through dictionary values and find the odd value, return the key of that value
            Dictionary<int,int> values = new Dictionary<int, int>();
            for (int i = 0; i < seq.Length; i++)
            {
                //check if key already exists in dictionary
                if (!values.ContainsKey(seq[i]))
                {
                    values.Add(seq[i], 1);
                }
                else
                {
                    values[seq[i]]++;
                }


            }

            foreach (var value in values)
            {
                if (value.Value % 2 != 0)
                {
                    return value.Key;
                }
            }


            return -1;
      }
       
    }
}