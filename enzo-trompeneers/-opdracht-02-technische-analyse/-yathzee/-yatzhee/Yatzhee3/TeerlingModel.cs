using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzhee3
{
    public class TeerlingModel
    {
        private int xOgen;
        private bool isRood = false;
        private string teerlingLabelText = "";

        public string TeerlingLabelText
        {
            get { return teerlingLabelText; }
            set { teerlingLabelText = value; }
        }

        public int XOgen
        {
            get { return xOgen; }
            set { xOgen = value; }
        }
        public bool IsRood
        {
            get { return isRood; }
            set { isRood = value; }
        }
    }
}
