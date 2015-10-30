namespace Yatzhee3
{
    partial class TeerlingView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TeerlingLabel = new System.Windows.Forms.Label();
            this.bgW = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // TeerlingLabel
            // 
            this.TeerlingLabel.BackColor = System.Drawing.Color.White;
            this.TeerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeerlingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeerlingLabel.Location = new System.Drawing.Point(14, 15);
            this.TeerlingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeerlingLabel.Name = "TeerlingLabel";
            this.TeerlingLabel.Size = new System.Drawing.Size(117, 90);
            this.TeerlingLabel.TabIndex = 0;
            this.TeerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TeerlingLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TeerlingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TeerlingLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeerlingView";
            this.Size = new System.Drawing.Size(161, 136);
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TeerlingLabel;
        private System.ComponentModel.BackgroundWorker bgW;
    }
}
