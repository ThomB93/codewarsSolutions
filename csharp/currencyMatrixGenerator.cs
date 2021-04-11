using System;
using System.Collections.Generic;

public class Kata
{
  public static string[] GenerateCurrencyMatrix(string currency)
  {
    List<string> currencyOrder = new List<string> {"EUR", "GBP", "AUD", "NZD", "USD", "CAD", "CHF", "JPY"};
    int currencyPos = 0;
    
    foreach(string s in currencyOrder)
    {
      if(s.Equals(currency))
      {
        currencyPos = currencyOrder.IndexOf(s);
        currencyOrder.Remove(s);
        break;
      }
    }
    
    string[] newStringArr = new string[7];
    for(int i = 0; i < 7; i++)
    {
      if(i<currencyPos)
        newStringArr[i] = currencyOrder[i] + currency;
      else
        newStringArr[i]  = currency + currencyOrder[i];
    }
    return newStringArr;
  }
}