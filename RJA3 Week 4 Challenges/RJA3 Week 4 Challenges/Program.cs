using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJA3_Week_4_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            FPS blackOps = new FPS("Gungun");
            blackOps.Title = "Black Ops";
            blackOps.GameScore = 6;
            blackOps.IsGood = false;

            RPG finalFantasy = new RPG();
            finalFantasy.Title = "Final Fantasy XV";
            finalFantasy.GameScore = 10;
            finalFantasy.IsGood = true;
            finalFantasy.isFinalFantasy = true;
        }
    }
}
