using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace RPGGame
{
    public class Hero : Character
    {
        public static FoxDraw foxDraw;
        public static int startingHeroX = 50;
        public static int startingHeroY = 50;
        private static int boardsize = 50;
        private Canvas Canvas { get; set; }

        public void Drawhero(FoxDraw foxDraw)
        {
            Hero.foxDraw = foxDraw;
            foxDraw.AddImage("./Assets/hero-down.png", startingHeroX, startingHeroY);
        }


        public void Left()
        {
            if (Area.Matrix[startingHeroY / boardsize][startingHeroX / boardsize - 1])
            {
                ((Image)foxDraw.UIList[100]).Source = new BitmapImage(new Uri("./Assets/hero-left.png", UriKind.Relative));
                foxDraw.SetPosition(foxDraw.UIList[100], startingHeroX - 50, startingHeroY);
                startingHeroX -= 50;
            }
        }

        public void Right()
        {
            if (Area.Matrix[startingHeroY / boardsize][startingHeroX / boardsize + 1])
            {
                ((Image)foxDraw.UIList[100]).Source = new BitmapImage(new Uri("./Assets/hero-right.png", UriKind.Relative));
                foxDraw.SetPosition(foxDraw.UIList[100], startingHeroX + 50, startingHeroY);
                startingHeroX += 50;
            }
        }

        public void Up()
        {
            if (Area.Matrix[startingHeroY / boardsize - 1][startingHeroX / boardsize])
            {
                ((Image)foxDraw.UIList[100]).Source = new BitmapImage(new Uri("./Assets/hero-up.png", UriKind.Relative));
                foxDraw.SetPosition(foxDraw.UIList[100], startingHeroX, startingHeroY - 50);
                startingHeroY -= 50;
            }
        }

        public void Down()
        {
            if (Area.Matrix[startingHeroY / boardsize + 1][startingHeroX / boardsize])
            {
                ((Image)foxDraw.UIList[100]).Source = new BitmapImage(new Uri("./Assets/hero-down.png", UriKind.Relative));
                foxDraw.SetPosition(foxDraw.UIList[100], startingHeroX, startingHeroY + 50);
                startingHeroY += 50;
            }
        }
    }
}

