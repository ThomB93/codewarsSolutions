using System;
using System.Collections.Generic;
public class PickPeaks
{
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        Dictionary<string, List<int>> results = new Dictionary<string, List<int>>();
            results.Add("pos", new List<int>());
            results.Add("peaks", new List<int>());

            
            for (int i = 1; i < arr.Length - 1; i++)
            {
                //normal peaks
                System.Console.WriteLine(arr[i]);
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    results["pos"].Add(i);
                    results["peaks"].Add(arr[i]);
                }
                
                //plateaus
                if(arr[i] == arr[i+1])
                {
                    int temp = i;
                    while(arr[temp] == arr[temp+1])
                    {
                        temp++;
                        if (temp > arr.Length-2)
                        {
                            break;
                        }
                    }

                    if (temp <= arr.Length - 2)
                    {
                        if (arr[temp] > arr[temp + 1] && arr[i] > arr[i - 1])
                        {
                            results["pos"].Add(i);
                            results["peaks"].Add(arr[i]);
                        }
                    }
                    
                    i = temp; 
                }
            }


            return results;
    }
}