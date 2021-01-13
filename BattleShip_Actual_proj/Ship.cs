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
        protected string name;
        protected int spaceSize;
        protected int health;
        protected bool sunk;

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

        public bool Sunk
        {
            get
            {
                return sunk;
            }
            set
            {
                sunk = value;
            }
        }

        // constructor
        public Ship ()
        {
            sunk = false;
        }

        // member methods
        public void LoseHealth()
        {
            health--;
        }
    }
}
