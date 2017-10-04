using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace RPGGame
{
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;
        Hero hero;
        Skeleton skeleton;
        Boss boss;


        public MainWindow()
        {
            InitializeComponent();
            hero = new Hero();
            skeleton = new Skeleton();
            boss = new Boss();
            foxDraw = new FoxDraw(canvas);
            Area.DrawMap(foxDraw);
            hero.Drawhero(foxDraw);
            skeleton.Drawskeleton(foxDraw);
            boss.Drawboss(foxDraw);

        }

        private void WindowKeyDown(object sender, KeyEventArgs e) // handling pressing keys, for moving your hero around
        {
            if (e.Key == Key.Left)
            {
                hero.Left();
            }

            if (e.Key == Key.Right)
            {
                hero.Right();
            }

            if (e.Key == Key.Up)
            {
                hero.Up();
            }

            if (e.Key == Key.Down)
            {
                hero.Down();
            }
        }
    }
}
