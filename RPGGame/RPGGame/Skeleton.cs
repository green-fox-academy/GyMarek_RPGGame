using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows.Controls;

namespace RPGGame
{
    public class Skeleton : Character
    {
        public static FoxDraw foxDraw;
        Random randomSkeleton = new Random();
        public static int startingHeroX = 50;
        public static int startingHeroY = 50;
        //private static int boardsize = 50;
        //private Canvas Canvas { get; set; }

        private static List<bool[]> skeletonMatrix = new List<bool[]>
        {
            new bool[] { false,false,false,false,false,false,false,false,false,false,false,false },
            new bool[] { false, false, true, true, false, true, false, true, true, true, true, false },
            new bool[] { false, true, true, true, false, true, false, true, false, false, true, false },
            new bool[] { false, true, false, false, false, true, false, true, false, false, true, false },
            new bool[] { false, true, true, true, true, true, false, true, true, true, true, false },
            new bool[] { false, false, false, false, false, true, false, false, false, false, true, false},
            new bool[] { false, true, false, true, false, true, true, true, true, false, true, false },
            new bool[] { false, true, false, true, false, true, false, false, true, false, true, false },
            new bool[] { false, true, true, true, true, true, false, false, true, true, true, false },
            new bool[] { false, true, false, false, false, true, true, true, true, false, true, false },
            new bool[] { false, true, true, true, false, true, false, false, true, true, true, false },
            new bool[] { false,false,false,false,false,false,false,false,false,false,false,false }
        };

        public void Drawskeleton(FoxDraw foxDraw)
        {
            Skeleton.foxDraw = foxDraw;
            int noOfSkeleton = 0;
            do
            {
                int x = randomSkeleton.Next(1, 11);
                int y = randomSkeleton.Next(1, 11);
                if (skeletonMatrix[y][x]==true)
                {
                    foxDraw.AddImage("./Assets/skeleton.png", startingHeroX * x, startingHeroY * y);
                    noOfSkeleton++;
                    skeletonMatrix[y][x] = false;
                }                
            } while (noOfSkeleton < 3);
        }
    }
}
