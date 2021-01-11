using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Actual_proj
{
    abstract class Ship
    {
        // member variables
        protected string name;
        protected int spaceSize;
        public int health;


        public double SpaceSize
        {
            get
            {
                return spaceSize;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        // constructor


        // member methods
        public void LoseHealth()
        {
            health--;
        }
    }
}
