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
        private string name;
        protected int score;
        protected int shipsRemaining;
        protected bool isTurn;
        protected GameBoard gameboard;

        // constructor
        Player (string inputName)
        {
            name = inputName;
            score = 0;
            gameboard = new GameBoard();
            shipsRemaining = 4;
        }

        // member methods
        public void IncrementScore()
        {
            score++;
        }
        public void DecrementShipCount()
        {
            shipsRemaining--;
        }
        public void ChangePlayerTurn()
        {
            isTurn = !isTurn;
        }
        public void AttemptAttack(int x, int y, Player currentPlayer, Player enemy)
        {
            if (enemy.gameboard.GameplayBoard[x,y] == null)
            {
                currentPlayer.gameboard.DisplayBoard[x, y] = "miss";
            }
            else if (enemy.gameboard.GameplayBoard[x, y] != null && currentPlayer.gameboard.DisplayBoard[x, y] != "miss")
            {
                foreach (Ship enemyship in enemy.gameboard.Ships)
                {
                    if (enemy.gameboard.GameplayBoard[x, y] == enemyship.Name)
                    {
                        enemyship.LoseHealth();
                        currentPlayer.gameboard.DisplayBoard[x, y] = "hit";
                        //check if ship is sunk
                    }
                }
            }
        }
    }
}
