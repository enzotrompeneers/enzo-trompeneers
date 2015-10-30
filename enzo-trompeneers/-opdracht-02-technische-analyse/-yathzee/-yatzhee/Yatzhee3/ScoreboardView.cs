using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzhee3
{
    public partial class ScoreboardView : UserControl
    {
        private ScoreboardController controller;
        
        public ScoreboardView(ScoreboardController c)
        {
            InitializeComponent();
            controller = c;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void UpdateScoreboard()
        {
            string newString = "Aantal Worpen: " + controller.model.Score.ToString();
            ScoreboardLabel.Text = newString;
        }

        
    }
}
