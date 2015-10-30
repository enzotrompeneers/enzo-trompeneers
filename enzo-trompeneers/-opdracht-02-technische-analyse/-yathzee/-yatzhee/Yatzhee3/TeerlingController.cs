using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzhee3
{
    public class TeerlingController
    {
        TeerlingView view;
        public TeerlingModel model;
        static Random rnd = new Random();

        public TeerlingController()
        {
            view = new TeerlingView(this);
            model = new TeerlingModel();
        }

        public TeerlingView getView()
        {
            return view;
        }
        
        public void Werp()
        {
            
            int randomTeerlingNummer = rnd.Next(1, 7);
            model.XOgen = randomTeerlingNummer;
           
        }

        public void Fixed()
        {   
            if (model.IsRood)
            {
                 model.IsRood = false;
            }
            else
            {
                 model.IsRood = true;
            }
        }

        public void UpdateUI()
        {
            int nieuwXOgen = model.XOgen;
            model.TeerlingLabelText = nieuwXOgen.ToString();
            view.UpdateUI();
        }
    }
}
