using System;
using System.Collections.Generic;
using System.Text;
class Kata
{
    public static string Solve(string s)
    {
        int upper = 0;
            int lower = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    upper++;
                }
                else
                {
                    lower++;
                }
            }

            string res;

            if (upper > lower)
            {
                res = s.ToUpper();
            }
            else
            {
                res = s.ToLower();
            }

            return res;
    }
}