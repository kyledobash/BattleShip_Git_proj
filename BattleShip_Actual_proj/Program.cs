using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Actual_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard test = new GameBoard();
            AircraftCarrier testShip2 = new AircraftCarrier();
            Destroyer testShip = new Destroyer();
            test.PopulateEmptyGameBoard();
            test.AddShipToGameBoard(1, 1, testShip);
            test.AddShipToGameBoard(1, 1, testShip2);

        }
    }
}
