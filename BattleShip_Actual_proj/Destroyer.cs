using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Actual_proj
{
    public class Destroyer : Ship
    {
        // member variables

        // constructor
        public Destroyer()
        {
            health = 2;
            size = 2;
            isItSunk = false;
            codeLetter = "D";
        }
        // member methods

    }
}
