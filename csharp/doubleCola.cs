using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Line
    {
        public static string WhoIsNext(string[] names , long n)
        { 
            double temp = 0; 
            while (n > names.Length)
            {
                n -= names.Length - 1;
                temp = (n * 0.5);
                n = (long)Math.Floor(temp);
                System.Console.WriteLine(n);
            }

            return names[n - 1];
        }
        }