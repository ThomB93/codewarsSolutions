public static class MonkeyCounter
{
  public static int[] MonkeyCount(int n)
  {
      int[] monkeys = new int[n];
      for(int i = 0; i<n;i++)
      {
        monkeys[i] = i+1;
      }
      return monkeys;
  }
}