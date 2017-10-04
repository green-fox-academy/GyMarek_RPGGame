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
        private static int boardsize = 50;
        private Canvas Canvas { get; set; }

        public void Drawskeleton(FoxDraw foxDraw)
        {
            Skeleton.foxDraw = foxDraw;
            foxDraw.AddImage("./Assets/skeleton.png", startingHeroX * randomSkeleton.Next(1, 10), startingHeroY * randomSkeleton.Next(1, 10));
            foxDraw.AddImage("./Assets/skeleton.png", startingHeroX * randomSkeleton.Next(1, 10), startingHeroY * randomSkeleton.Next(1, 10));
            foxDraw.AddImage("./Assets/skeleton.png", startingHeroX * randomSkeleton.Next(1, 10), startingHeroY * randomSkeleton.Next(1, 10));
        }
    }
}
