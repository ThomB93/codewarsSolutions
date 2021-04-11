using System;
using System.Linq;

public class Dubstep
    {
        public static string SongDecoder(string input)
        { 
           bool contains = true;
            string s = input.Replace("WUB", " ").Trim();
            while (contains)
            {
                s = s.Replace("  ", " ");
                contains = s.Contains("  ");
            }

            return s;
        }
    }