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
        public void IncrementScore()
        {
            score++;
        }
        public void AttemptAttack(int xCoordinate, int yCoordinate, Player enemy) //rethink parameters needed
        {
            //check for ship or empty space (helper method)
            //add hit or miss to gameboard(helper method)

            //decrement ships health(helper method),
            //bool conditional to check ships health (helper method)
                //if ship health is 0
                    //change ship sunk bool (helper method)
                    //increment attacking player's score (helper method)

        }     
    }
}
