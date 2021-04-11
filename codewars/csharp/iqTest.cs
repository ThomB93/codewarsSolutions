using System;
using System.Linq;

public class IQ
    {
        public static int Test(string numbers)
        { 
                        int oddCounter = 0;
            int evenCounter = 0;
            string[] intNumbers = numbers.Split(" ");
            
            for (int i = 0; i < intNumbers.Length; i++)
            {
                //if even
                if(Convert.ToInt32(intNumbers[i]) % 2 == 0)
                {
                    evenCounter++;
                }
                else
                {
                    oddCounter++;
                }
            }

            if (oddCounter > evenCounter)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (Convert.ToInt32(intNumbers[i]) % 2 == 0)
                    {
                        return i + 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (Convert.ToInt32(intNumbers[i]) % 2 == 1)
                    {
                        return i + 1;
                    }
                }
            }

            return -1;
        }
    }