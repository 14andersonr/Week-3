using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJA3_Week3_Challenges
{
    public abstract class Games
    {
        public string Title { get; set; }

        public int GameRating { get; set; }

        public bool FitforKids { get; set; }

        public virtual void GetFeedback() // virtual classes can have a body, abstract cannot.
        {
            if (Title == null)
            {
                Console.WriteLine("What's the Title of the game?");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("");
            }
        }

        //public abstract void Testing(string test);

    }
}
