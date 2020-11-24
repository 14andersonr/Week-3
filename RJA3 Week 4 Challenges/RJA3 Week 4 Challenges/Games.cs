using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJA3_Week_4_Challenges
{
    public abstract class Games
    {
        public string Title { get; set; }

        public int GameScore { get; set; }

        public bool IsGood { get; set; }

        public virtual string GetFeedback()
        {
            int originalGameScore = GameScore;
            Console.WriteLine("How good is this game on a scale of 1 to 10?");
            string newGameScore = Console.ReadLine();

            return newGameScore; 
        }

        public Games() { }

        public Games(string title, int gameScore, bool isGood)
        {
            title = Title;
            gameScore = GameScore;
            isGood = IsGood;
        }
    }

    public class RPG : Games
    {
        public bool isFinalFantasy { get; set; }
    }

    public class FPS : Games
    {
        public string TypeOfGun { get; set; }

        public FPS() { }

        public FPS(string typeOfGun)
        {
            typeOfGun = TypeOfGun;
        }
    }
}
