public class Kata
{
  public static string UefaEuro2016(string[] teams, int[] scores)
  {
    string winner = "";
    if(scores[0] > scores[1])
      winner = teams[0] + " won!";
    else if(scores[1] > scores[0])
      winner = teams[1] + " won!";
    else
      winner = "teams played draw.";
    return "At match " + teams[0] + " - " + teams[1] + ", " + winner;
  }
}