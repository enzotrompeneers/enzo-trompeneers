using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzhee3
{
    public class ScoreboardController
    {
        ScoreboardView view;
        public ScoreboardModel model;

        public ScoreboardView getView()
        {
            return view;
        }

        public ScoreboardController()
        {
            view = new ScoreboardView(this);
            model = new ScoreboardModel();
        }
        public void UpdateAantalWorpen()
        {
            model.Score += 1;

            view.UpdateScoreboard();
        }
        public void UpdateScore()
        {

        }

        


    }
}
