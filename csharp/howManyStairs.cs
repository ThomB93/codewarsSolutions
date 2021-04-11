using System;
public class Kata
{
  public static long StairsIn20(int[][] stairs)
  {
      int yearSum = 0;
      int row = stairs.Length;
      int col = stairs[0].Length;
      for (int i = 0; i < row; i++) {
      for (int j = 0; j < col; j++) {
          yearSum += stairs[i][j];
      }
  }
  int twentyYear = yearSum * 20;
  return twentyYear;
  }
}