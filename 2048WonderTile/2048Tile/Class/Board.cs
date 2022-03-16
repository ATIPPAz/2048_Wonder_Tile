using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Tile.Class
{
    internal class Board
    {
        int[,] Tiles;
        Random rnd = new Random();
        List<int> IndexEmpty;
        public void start()
        {
            IndexEmpty = new List<int>();
            Tiles = new int[4, 4];
            for (int times = 0; times <= 1; times++)
            {
                int col, row, value;
                col = rnd.Next(4);
                row = rnd.Next(4);
                value = rnd.Next(1, 3) * 2;
                if (Tiles[col, row] == 0)
                {
                    Tiles[col, row] = value;
                }
                else
                {
                    times--;
                }
            }
            for (int times = 0; times <= 15; times++)
            {
                Console.Write((times / 4).ToString() + (times % 4).ToString() + "value is :");
                Console.WriteLine(Tiles[times / 4, times % 4].ToString());
            }

        }

        public void RandomTileValue()
        {

        }
        public void End()
        {
            Tiles = new int[4, 4];
        }
    }
}
