using System;
using System.Collections;
using System.Linq;

public class MinMax 
{
    public static int[] minMax(int[] lst) 
    {
        int max = lst.Max();
        int min = lst.Min();
        
        int[] ret = new int[2];
        ret[0] = min;
        ret[1] = max;
        
        return ret;
    }
}