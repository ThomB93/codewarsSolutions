public class Kata
{
  public static int[] PreFizz(int n) 
  {
    int[] numbers = new int[n];
    for(int i = 0; i < n; i++)
    {
      numbers[i] = i+1;
    }
    return numbers;
  }
}