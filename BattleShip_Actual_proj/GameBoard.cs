﻿using System;
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
            for (int i = 0; i < this.gameboard.Length - 1; i++)
            {
                // this conditional is hardcoded, only way could get loop to work
                for (int j = 0; j < 20; j++)
                {
                    this.gameboard[i, j] = "-";
                }
            }
        }
    }
}
