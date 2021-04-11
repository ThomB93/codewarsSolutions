using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class CountDig 
{
    
    public static int NbDig(int n, int d) 
    {
        //square all numbers from 0 to n, and save all results in array
            int[] squaredResults = new int[n+1];
            for (int i = 0; i <= n; i++)
            {
                squaredResults[i] = i * i;
            }
            //convert integer results to strings and count number of times 'd' appears
            string[] resultStrings = squaredResults.Select(x => x.ToString()).ToArray();
            int counter = 0;
            foreach (var entry in resultStrings)
            {
                foreach (var digit in entry)
                {
                    if ((int)Char.GetNumericValue(digit) == d)
                    {
                        counter++;
                    }
                }
            }
            return counter;
    }
}