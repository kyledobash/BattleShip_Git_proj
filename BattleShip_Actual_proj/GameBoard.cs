using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Actual_proj
{
    class GameBoard
    {
        // member variables
        protected int[,] board;

        public int[,] Board
        {
            get
            {
                return board;
            }
        }

        // constructor
        GameBoard()
        {
            board = new int[20,20];
        }
        // member methods
        public void PopulateGameBoard()
        {
            ////create a current coordinate
            //string currentCoordinate;

            //for (int i = 0; i < board.Length; i++)
            //{
            //    for (int j = 0; j < board[i].Length; j++)
            //    {
            //        array
            //    }
            //}
        }
        public void CheckForShip(int coordinate)
        {
            //coordinate = !coordinate;
        }
    }
}
