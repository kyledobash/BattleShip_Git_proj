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
        public string[,] gameboard;

        // constructor
        public GameBoard()
        {
            gameboard = new string[20, 20];

        }

        // member methods
        public void PopulateEmptyGameBoard()
        {
            for (int i = 0; i < 20; i++)
            {
                // this conditional is hardcoded, only way could get loop to work
                for (int j = 0; j < 20; j++)
                {
                    this.gameboard[i, j] = "-";
                }
            }
        }
        public void AddMissToGameBoard(int xCoordinate, int yCoordinate)
        {
            this.gameboard[xCoordinate, yCoordinate] = "o";
        }
        public void AddHitToGameBoard(int xCoordinate, int yCoordinate)
        {
            this.gameboard[xCoordinate, yCoordinate] = "x";
        }
        public void AddShipToGameBoard(int xCoordinate, int yCoordinate, Ship ship)
        {
            bool spotIsEmpty = true;

            for (int i = 0; i < ship.size; i++)
            {
                if (this.gameboard[xCoordinate, yCoordinate + i] != "-")
                {
                    spotIsEmpty = false;
                    break;
                }
            }

            if (spotIsEmpty)
            {
                for (int i = 0; i < ship.size; i++)
                {
                    this.gameboard[xCoordinate, yCoordinate + i] = ship.codeLetter;
                }
            }
            else
            {
                throw new Exception("There is already a ship at " + xCoordinate + ", " + yCoordinate);
            }
        }
    }
}
