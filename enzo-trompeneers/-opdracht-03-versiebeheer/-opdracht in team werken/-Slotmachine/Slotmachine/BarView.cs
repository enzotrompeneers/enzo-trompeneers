using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slotmachine
{
    public partial class BarView : UserControl
    {
        private BarController controller;

        private Image banana = Image.FromFile("banana.png");
        private Image cherry = Image.FromFile("cherry.png");
        private Image strawberry = Image.FromFile("strawberry.png");
        private Image penguin = Image.FromFile("penguin.png");
        private Image cash = Image.FromFile("cash.png");
        int bananaScore = 10;
        int cherryScore = 25;
        int strawberryScore = 50;
        int penguinScore = 100;
        int cashScore = 200;
        

        public Image[] aImages = new Image[5];
        

        static int seeder = 0; // changes time

        Random rnd = new Random( seeder++ );

        private int firstSlot;
        private int secondSlot;
        private int thirdSlot;

        private int beginArray = 0;
        private int endArray = 5;

        public int _score;

        


        public BarView (BarController initController)
        {
            controller = initController;
            InitializeComponent();
        }

        private void disableButtonAndChangeMoves()
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            controller.slot.ChangeMoves();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            firstSlot = rnd.Next(beginArray, endArray);
            pctBox1.Image = aImages[secondSlot];
            pctBox2.Image = aImages[thirdSlot];
            pctBox3.Image = aImages[firstSlot];

           
            disableButtonAndChangeMoves();
            controller.slot.ThreeInARowControl();

        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            thirdSlot = rnd.Next(beginArray, endArray);
            pctBox1.Image = aImages[thirdSlot];
            pctBox2.Image = aImages[firstSlot];
            pctBox3.Image = aImages[secondSlot];

            disableButtonAndChangeMoves();
            controller.slot.ThreeInARowControl();

        }

        public void LoadImages()
        {
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            firstSlot = rnd.Next(beginArray, endArray);
            secondSlot = rnd.Next(beginArray, endArray);
            thirdSlot = rnd.Next(beginArray, endArray);

            aImages[0] = banana;
            aImages[1] = cherry;
            aImages[2] = penguin;
            aImages[3] = cash;
            aImages[4] = strawberry;

            pctBox1.Image = aImages[firstSlot];
            pctBox2.Image = aImages[secondSlot];
            pctBox3.Image = aImages[thirdSlot];
            Score();
        }

        public void Score()
        {
            Image checkImage = pctBox2.Image;

            int score = 0;

            if (checkImage == banana)
            {
                score = bananaScore;
            }
            if (checkImage == cherry)
            {
                score = cherryScore;
            }
            if (checkImage == strawberry)
            {
                score = strawberryScore;
            }
            if (checkImage == penguin)
            {
                score = penguinScore;
            }
            if (checkImage == cash)
            {
                score = cashScore;
            }

            _score = score;
            //MessageBox.Show(score.ToString());
        }


        private void BarView_Load(object sender, EventArgs e)
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;
        }

       

    }
}
