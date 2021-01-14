using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Actual_proj
{
    public abstract class Ship
    {
        // member variables
        public int health;
        public int size;
        public string codeLetter;
        public bool isItSunk = false;

        // constructor

        // member methods
        public void DecrementHealth()
        {
            health--;
        }
        public void SinkShip()
        {
            isItSunk = true;
        }
        public bool CheckShipHealth()
        {
            if (health == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
