using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;


namespace RPGGame
{
    public class Hero
    {
        public static FoxDraw foxDraw;
        public static int startingHeroX = 0;
        public static int startingHeroY = 0;

        //private static List<string[]> board = new List<string[]>()
        //{
        //    new string[] {"floor", "floor", "floor", "wall", "floor", "wall", "floor", "floor", "floor", "floor"},
        //    new string[] {"floor", "floor", "floor", "wall", "floor", "wall", "floor", "wall", "wall", "floor"},
        //    new string[] {"floor", "wall", "wall", "wall", "floor", "wall", "floor", "wall", "wall", "floor"},
        //    new string[] {"floor", "floor", "floor", "floor", "floor", "wall", "floor", "floor", "floor", "floor"},
        //    new string[] { "wall", "wall", "wall", "wall", "floor", "wall", "wall", "wall", "wall", "floor"},
        //    new string[] {"floor", "wall", "floor", "wall", "floor", "floor", "floor", "floor", "wall", "floor"},
        //    new string[] {"floor", "wall", "floor", "wall", "floor", "wall", "wall", "floor", "wall", "floor"},
        //    new string[] {"floor", "floor", "floor", "floor", "floor", "wall", "wall", "floor", "wall", "floor"},
        //    new string[] {"floor", "wall", "wall", "wall", "floor", "floor", "floor", "floor", "wall", "floor"},
        //    new string[] {"floor", "floor", "floor", "wall", "floor", "wall", "wall", "floor", "floor", "floor"}

        //};
        

        public void Drawhero(FoxDraw foxDraw)
        {
            Hero.foxDraw = foxDraw;
            foxDraw.AddImage("./Assets/hero-down.png", startingHeroX, startingHeroY);
        }
        

        public void Left()
        {
            foxDraw.AddImage("./Assets/hero-left.png", startingHeroX - 50, startingHeroY);
            startingHeroX -= 50;           
        }

        public void Right()
        {
            foxDraw.AddImage("./Assets/hero-right.png", startingHeroX + 50, startingHeroY);
            startingHeroX += 50;
        }

        public void Up()
        { 
            foxDraw.AddImage("./Assets/hero-up.png", startingHeroX, startingHeroY - 50);
            startingHeroY -= 50;
        }

        public void Down()
        {
            foxDraw.AddImage("./Assets/hero-down.png", startingHeroX, startingHeroY + 50);
            startingHeroY += 50;
        }
    }
}

