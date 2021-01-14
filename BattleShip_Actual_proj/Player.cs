using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Actual_proj
{
    public class Player
    {
        // member variables
        GameBoard myGameBoard;
        public int score;

        // constructor
        public Player()
        {
            myGameBoard = new GameBoard();
            score = 0;
        }
       
        // member methods
        public void AttemptAttack(int xCoordinate, int yCoordinate, Player enemy)
        {
            //call helper methods to check for ship or empty space
            //call helper methods to add hit to miss

            //decrement ships health,
            // possibly add helper method to check ships health
                //if ship health is 0
                    //increment attacking player's score

        }
      
    }
}
