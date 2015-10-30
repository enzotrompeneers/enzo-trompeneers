using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Slotmachine
{
    public class BarController
    {
        public frmSlotmachine slot;
        public  BarView view;

        public BarController( frmSlotmachine initSlot ) 
        {
            slot = initSlot;
            view = new BarView(this);
        }


 
    }
}
