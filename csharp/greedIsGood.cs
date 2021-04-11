using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int Score(int[] dice) {
    int score = 0;

            //Array.Sort(dice);
            //terning, occurences
            Dictionary<int, int> result = new Dictionary<int, int>()
            {
                {1, 0},
                {2, 0},
                {3, 0},
                {4, 0},
                {5, 0},
                {6, 0}
            };


            for (int i = 0; i < dice.Length; i++)
            {
                switch (dice[i])
                {
                    case 1:
                        result[1]++;
                        break;
                    case 2:
                        result[2]++;
                        break;
                    case 3:
                        result[3]++;
                        break;
                    case 4:
                        result[4]++;
                        break;
                    case 5:
                        result[5]++;
                        break;
                    case 6:
                        result[6]++;
                        break;
                    default:
                        break;
                }
            }
            //Three 1's => 1000 points
            //Three 6's =>  600 points
            //Three 5's =>  500 points
            //Three 4's =>  400 points
            //Three 3's =>  300 points
            //Three 2's =>  200 points
            //One   1   =>  100 points
            //One   5   =>   50 point

            int[] numbers = new int[6];
            foreach (var item in result)
            {
                if(item.Value >= 3) {
                    switch (item.Key)
                    {
                        case 1:
                            score+=1000;
                            numbers[0] = item.Value - 3;
                            break;
                        case 2:
                            score+=200;
                            numbers[1] = item.Value - 3;
                            break;
                        case 3:
                            score+=300;
                            numbers[2] = item.Value - 3;
                            break;
                        case 4:
                            score+=400;
                            numbers[3] = item.Value - 3;
                            break;
                        case 5:
                            score+=500;
                            numbers[4] = item.Value - 3;
                            break;
                        case 6:
                            score+=600;
                            numbers[5] = item.Value - 3;
                            break;
                        default:
                            break;
                    }
                }
                if(item.Value < 3) {
                    switch (item.Key)
                    {
                        case 1:
                            numbers[0] = item.Value;
                            break;
                        case 5:
                            numbers[4] = item.Value;
                            break;
                        default:
                            break;
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if(i == 0 )
                {
                    score += numbers[i] * 100;
                }
                else if(i == 4) {
                    score += numbers[i] * 50;
                }
            }

            return score;
  }
}