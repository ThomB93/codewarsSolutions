public class SequenceSum
{
  public static string ShowSequence(int n)
  { 
    if(n == 0)
      {
        string s = "0=0";
        return s;
      }
    if(n<0)
    {
      string s = n + "<0";
      return s;
    }
  
    int[] numberSeries = new int[n+1];  
    int result = 0;
    for(int i = 0; i<numberSeries.Length; i++)
    {
      numberSeries[i] = i;
      result = result + i;
    }
    string returnString = "";
    for(int i = 0; i<numberSeries.Length; i++)
    {
      if(i == n)
      {
        returnString += numberSeries[i].ToString() + " = " + result;
        break;
      }
      returnString += numberSeries[i].ToString() + "+";
    }
    return returnString;
  }
}