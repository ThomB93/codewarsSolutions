using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        int[] sumArray = new int[2];
        int posSum = 0;
        int negSum = 0;

        if(input == null || input.Length == 0) {
          return new int[] {};
        }

        for (int i = 0;i < input.Length ;i++ ) {
          if(input[i] > 0)
            posSum += 1;
          else
            negSum += input[i];
        }
        sumArray[0] = posSum;
        sumArray[1] = negSum;
        return sumArray; //return an array with count of positives and sum of negatives
    }
}