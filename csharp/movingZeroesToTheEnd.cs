using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    //how many zeroes are there in the array?
            //what are the indexes of the zeros?
            //1. swap the 0 with the lowest index with the element to the right (index+1)
            List<int> arrayAsList = arr.ToList();

            int numberOfZeroes = arrayAsList.Where(i => i == 0).Count();

            Console.WriteLine(numberOfZeroes);
            arrayAsList.RemoveAll(i => i == 0);

             
            for (int i = 0; i < numberOfZeroes; i++)
            {
                arrayAsList.Add(0);
            }

            return arrayAsList.ToArray();
  }
}