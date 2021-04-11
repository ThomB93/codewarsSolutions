class AverageSolution
{
  public static double FindAverage(double[] array)
  {
    double avg = 0;
    double total = 0;
    for (int i = 0;i < array.Length ;i++ ) {
      total += array[i];
    }
    if(array.Length > 0)
      avg = total / array.Length;
    return avg;
  }
} 