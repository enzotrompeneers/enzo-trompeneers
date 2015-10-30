using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yatzhee3
{
    public partial class Yahtzee : Form
    {
        public Yahtzee()
        {
            InitializeComponent();
        }

        int xTeerlingen = 5;
        int xSoortenScore = 3;
        int counter = 0;
        List<TeerlingController> teerlingen = new List<TeerlingController>();
        List<ScoreboardController> scoreboard = new List<ScoreboardController>();
        

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < xSoortenScore; i++)
            {
                ScoreboardController tijdelijkeScore = new ScoreboardController();
                scoreboard.Add(tijdelijkeScore);
            }

            for (int i = 0; i < xTeerlingen; i++)
            {
                TeerlingController tijdelijkeTeerling = new TeerlingController();
                teerlingen.Add(tijdelijkeTeerling);
            }

            for (int i = 0; i < xTeerlingen; i++)
            {
                TeerlingView teerlingView = teerlingen[i].getView();
                int hPosition = i * teerlingView.Width;
                teerlingView.Location = new System.Drawing.Point(hPosition, 0);
                Controls.Add(teerlingView);
            }

            for (int i = 0; i < xSoortenScore; i++)
            {
                ScoreboardView scoreboardView = scoreboard[i].getView();
                int hPosition = i * scoreboardView.Width;
                scoreboardView.Location = new System.Drawing.Point(this.Width/8 + hPosition, 220);
                Controls.Add(scoreboardView);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (scoreboard[0].model.Score < 3)
            {
                for (int i = 0; i < xTeerlingen; i++)
                {
                    if (!teerlingen[i].model.IsRood)
                    {
                        teerlingen[i].Werp();

                        teerlingen[i].UpdateUI();
                    }
                }
                scoreboard[0].UpdateAantalWorpen();
                
            }
            if (counter > 2)
            {
                btnWerpen.Enabled = false;
                MessageBox.Show("Game Over");
            }
            
        }
    }
}
