using System;

public class Solution
{
    public static bool solve(string s){  
       bool isConsecutive = false;
            //store alphabet as string
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            //create array from string
            char[] inputCharArray = s.ToCharArray();
            //sort the array, so that letters are in alphabetical order
            Array.Sort(inputCharArray);
            //find where to start in the alphabet
            int indexOfFirstLetter = Array.IndexOf(alphabet, inputCharArray[0]);
            int charArrayIndexCounter = 0;

            for (int i = indexOfFirstLetter; i < alphabet.Length-1; i++)
            {
                if (charArrayIndexCounter == inputCharArray.Length)
                {
                    break;
                }
                if (alphabet[i] == inputCharArray[charArrayIndexCounter])
                {
                    isConsecutive = true;
                }
                else
                {
                    isConsecutive = false;
                    break;
                }

                charArrayIndexCounter++;
            }

            return isConsecutive;
    }
}