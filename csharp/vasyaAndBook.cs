using System;
 
public class Book
    {
        public static int DayIs(int pages, int [] days)
        {
           int pagesRead = 0;
            while (pagesRead < pages)
            {
                for (int i = 0; i < 7; i++)
                {
                    pagesRead += days[i];
                    if (pagesRead >= pages)
                        return i + 1;
                }
            }
            return -1;
        }
    }