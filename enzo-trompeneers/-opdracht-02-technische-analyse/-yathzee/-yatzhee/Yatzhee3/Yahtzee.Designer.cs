using System.Collections.Generic;
using System.Drawing;

namespace Yatzhee3
{
    partial class Yahtzee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWerpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWerpen
            // 
            this.btnWerpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWerpen.Location = new System.Drawing.Point(25, 241);
            this.btnWerpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnWerpen.Name = "btnWerpen";
            this.btnWerpen.Size = new System.Drawing.Size(78, 22);
            this.btnWerpen.TabIndex = 0;
            this.btnWerpen.Text = "Werpen";
            this.btnWerpen.UseVisualStyleBackColor = true;
            this.btnWerpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 281);
            this.Controls.Add(this.btnWerpen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Yahtzee";
            this.Text = "Yahtzee";
            this.Load += new System.EventHandler(this.Yahtzee_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnWerpen;
    }
}

