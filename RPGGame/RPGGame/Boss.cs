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
        Random randomBoss = new Random();
        public static int startingHeroX = 50;
        public static int startingHeroY = 50;

        public void Drawboss(FoxDraw foxDraw)
        {
            Boss.foxDraw = foxDraw;
            
                int x = randomBoss.Next(1, 11);
                int y = randomBoss.Next(1, 11);
                if (skeletonMatrix[y][x] == true)
                {
                foxDraw.AddImage("./Assets/boss.png", startingHeroX * x, startingHeroY * y);   
                    skeletonMatrix[y][x] = false;
                }           
        }

    }
}
