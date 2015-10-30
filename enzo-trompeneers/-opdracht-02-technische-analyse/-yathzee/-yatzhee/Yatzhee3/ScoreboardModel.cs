using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzhee3
{
    public class ScoreboardModel
    {

        string[] mScoreNamen = { "Aantal Worpen :", "Score :", "Highscore :" };
        private int xWorpen;
        private int score;

        public string[] ScoreNamen
        {
            get { return mScoreNamen; }
        }

        public int XWorpen
        {
            get { return xWorpen; }
            set { xWorpen = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

    }
}
