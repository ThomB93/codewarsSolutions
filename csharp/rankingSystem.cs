// TODO: create the User class/object
// it must support rank, progress, and the incProgress(int rank) method
using System;
public class User
    {
        public int rank { get; private set; }

        public int progress { get; private set; }

        public int[] ranks { get; private set; }

        public User()
        {
            rank = -8;
            ranks = new int[] {-8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8};
        }

        public void incProgress(int activityRank)
        {
            if (activityRank > 8 || activityRank < -8 || activityRank == 0)
            {
                throw new ArgumentException("rank was outside of the allowed range");
            }

            int rankIndex = Array.IndexOf(ranks, rank);
            int activityRankIndex = Array.IndexOf(ranks, activityRank);



            int diff = rankIndex - activityRankIndex;

            if (diff == 0)
            {
                progress += 3;
            } 
            else if(diff == 1)
            {
                progress += 1;
            }
            else if(diff >= 2) {
                progress += 0;
            }
            else
            {
                progress += 10 * diff * diff;
            }

            while (progress > 100)
            {
                if(progress >= 100 && rank != 8) {
                    rank++;
                    progress -= 100;
                }

                if (rank == 0)
                {
                    rank++;
                }
              
            }
            if (rank == 8)
                {
                    progress = 0;
                }

        }
    }