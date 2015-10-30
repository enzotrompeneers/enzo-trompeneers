using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slotmachine
{
    public partial class frmSlotmachine : Form
    {
        private int totalPoints = 100;
        private int gameCost = 1;
        private int beginMoves = 3;
        List<BarView> listBarControllers = new List<BarView>();
        private int[] aScore = new int[5] {10, 25, 50, 100, 200};
        private int[] receiveScore = new int[3];

        private BarController controller;

        public frmSlotmachine(BarController initController)
        {

            controller = initController;
            InitializeComponent();
        }


        public frmSlotmachine()
        {
            InitializeComponent();
        }
        public void ChangeMoves()
        {
            int currentMoves;
            Int32.TryParse(lblMoves.Text, out currentMoves);
            lblMoves.Text = (currentMoves - 1).ToString();
        }


        private void frmSlotmachine_Load(object sender, EventArgs e)
        {
            int i = 0, iLen = 3, xPos = -20, yPos = 0, XMove = 170;

            for (; i < iLen; i++)
            {
                BarController bController = new BarController( this );
                BarView bView = bController.view;
                bView.Location = new System.Drawing.Point(xPos, yPos);
                Controls.Add(bView);
                xPos += XMove;

                listBarControllers.Add(bView);

            }

        }
        public void ThreeInARowControl()
        {
        if (receiveScore[0] == receiveScore[1] && receiveScore[1] == receiveScore[2])
                {

                    MessageBox.Show("gelukt");
                    int score = receiveScore[0];
                    Int32.TryParse(lblPoints.Text, out totalPoints);
                    totalPoints += score;
                    lblPoints.Text = totalPoints.ToString();
                }
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            lblMoves.Text = beginMoves.ToString() ;
            
            if (totalPoints < gameCost)
            {
                btnSpin.Enabled = false;
                MessageBox.Show("GAME OVER");
                
            }
            else
            {
                totalPoints -= gameCost;
                lblPoints.Text = totalPoints.ToString();

                int i = 0;
                foreach (var item in listBarControllers)
                {
                    item.LoadImages();
                    receiveScore[i] = item._score;
                    //MessageBox.Show(receiveScore[i].ToString());
                    i++;
                }
                ThreeInARowControl();

               
               

            }
            


        }


    }
}
