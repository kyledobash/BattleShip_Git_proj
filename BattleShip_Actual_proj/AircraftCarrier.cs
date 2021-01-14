using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Actual_proj
{
    public class AircraftCarrier : Ship
    {
        // member variables

        // constructor
        public AircraftCarrier()
        {
            health = 5;
            size = 5;
            isItSunk = false;
            codeLetter = "A";
        }
        // member methods

    }
}
