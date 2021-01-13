using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Actual_proj
{
    public class GameBoard
    {
        // member variables
        protected string[,] board;
        protected List<Ship> ships;

        public string[,] Board
        {
            get
            {
                return board;
            }
        }

        // constructor
        public GameBoard()
        {
            board = new string[20,20];
            ships = new List<Ship>();
        }
        // member methods
        public void CheckForShip(int coordinate)
        {
            //coordinate = !coordinate;
        }
    }
}
