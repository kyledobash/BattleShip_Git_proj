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
        public void PlaceShip(int x, int y, Ship boat)
        {            
            if (CheckSpaceIsEmpty(x,y,boat))
            {
                for (int j = 0; j < boat.SpaceSize; j++)
                {
                    board[x, y + j] = boat.Name;
                }
            }
            else
            {
                throw new Exception("There is already a boat at these coordinates");
            }
        }

        public bool CheckSpaceIsEmpty(int x, int y, Ship boat)
        {
            bool spaceIsEmpty = true;

            for (int i = 0; i < boat.SpaceSize; i++)
            {
                if (board[x, y + i] != null)
                {
                    spaceIsEmpty = false;
                }
            }
            return spaceIsEmpty;
        }
    }
}
