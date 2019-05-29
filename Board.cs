using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
namespace WpfApp1
{
    class Board
    {
        public static Rectangle[,] map;
        public static int[,] playerPos;
        public Board()
        {
            playerPos = new int[,]
            {
                {1,1,1 },
                {0,0,0 },
                {1,1,1 }
            };
        }
        public void updateBoard()
        {

        }
    }
}
