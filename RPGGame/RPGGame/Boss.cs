using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    public class Boss : Character
    {
        public static FoxDraw foxDraw;
        public static int startingBossX = 50;
        public static int startingBossY = 50;


        public void Drawboss(FoxDraw foxDraw)
        {
            Boss.foxDraw = foxDraw;
            Random randomBoss = new Random();

            bool isPlace = false;
            do
            {
                int x = randomBoss.Next(1, 11);
                int y = randomBoss.Next(1, 11);
                if (Skeleton.skeletonMatrix[y][x] == true)
                {
                    foxDraw.AddImage("./Assets/boss.png", startingBossX * x, startingBossY * y);
                    isPlace = true;
                }
            } while (isPlace != true);
        }
    }
}
