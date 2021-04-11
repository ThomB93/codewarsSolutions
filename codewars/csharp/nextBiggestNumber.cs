using System;
using System.Linq;
public class Kata
{
    public static long NextBiggerNumber(long n)
    {
      //return -1 if number 0-9, or if all digits in number are the same
            if (n < 10)
                return -1;

            string stringNumber = n.ToString();
            char firstDigit = stringNumber[0];
            int counter = 0;

            for (int i = 1; i < stringNumber.Length; i++)
            {
                if (stringNumber[i] == firstDigit)
                {
                    counter++;
                }
            }
            if(counter == stringNumber.Length) {
                return -1;
            }

            char[] output = stringNumber.ToCharArray();

            
            int index = 0;

            for (int i = stringNumber.Length-1; i > 0; i--)
            {
                if(stringNumber[i] > stringNumber[i - 1]) {
                    index = i-1;
                    break;
                    /* temp = output[i].ToString();
                    output[i] = output[i-1];
                    output[i-1] = temp[0]; */
                }
            }

            string rightSide = new string(output).Substring(index+1, stringNumber.Length-(index+1));
            string leftSide = new string(output).Substring(0, index+1);
            Console.WriteLine("Right side: " + rightSide);
            //sort right side
            int[] arr = rightSide.Select(c => Convert.ToInt32(Char.GetNumericValue(c))).ToArray();
            //replace index value with next highest value in arr
            
            Array.Sort(arr);
            rightSide = string.Join("", arr);
            Console.WriteLine("Right side after sort: " + rightSide);

            char temp;
            char[] rightOutput = rightSide.ToCharArray();
            char[] leftOutput = leftSide.ToCharArray();

            for (int i = 0; i <= rightSide.Length-1; i++)
            {
                if(rightSide[i] > leftSide[index])
                {
                    temp = rightSide[i];
                    rightOutput[i] = leftSide[index];
                    leftOutput[index] = temp;
                    char[] result = leftOutput.Concat(rightOutput).ToArray();
                    return Convert.ToInt64(new string(result));

                }
            }

            return -1;
    }
}