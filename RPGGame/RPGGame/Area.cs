using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows;
using System.Windows.Controls;

namespace RPGGame
{
    public class Area
    {
        private static int boardsize = 50;

        private static List<bool[]> matrix = new List<bool[]>
        {
            new bool[] { false,false,false,false,false,false,false,false,false,false,false,false },
            new bool[] { false, true, true, true, false, true, false, true, true, true, true, false },
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
        public static List<bool[]> Matrix
        {
            get
            {
                return matrix;
            }
        }

        public static void DrawMap(FoxDraw foxDraw)
        {
            int y = 0;
            int x = 0;
            for (int i = 1; i < matrix.Count - 1; i++)
            {
                y = i * boardsize;
                for (int j = 1; j < matrix.Count - 1; j++)
                {
                    x = j * boardsize;
                    if (matrix[i][j] == true)
                    {
                        foxDraw.AddImage("./Assets/floor.png", x, y);
                    }
                    else
                    {
                        foxDraw.AddImage("./Assets/wall.png", x, y);
                    }
                }
            }
        }
    }
}
