public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    //insert brilliant code here
            if (walk.Length != 10) return false;
            int sumN = 0, sumW = 0, sumE = 0, sumS = 0;

            foreach(string s in walk)
            {
                switch(s.ToLower()){
                    case "n":
                        sumN++;
                        break;
                    case "s":
                        sumS++;
                        break;
                    case "e":
                        sumE++;
                        break;
                    case "w":
                        sumW++;
                        break;
                }
            }
            if(sumN == sumS && sumE == sumW) {
                return true;
            }
            return false;
  }
}