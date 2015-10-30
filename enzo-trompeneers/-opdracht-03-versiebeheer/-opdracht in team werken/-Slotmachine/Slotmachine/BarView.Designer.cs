namespace Slotmachine
{
    partial class BarView
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
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.pctBox1 = new System.Windows.Forms.PictureBox();
            this.pctBox2 = new System.Windows.Forms.PictureBox();
            this.pctBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(47, 20);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(123, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(47, 313);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(123, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // pctBox1
            // 
            this.pctBox1.Location = new System.Drawing.Point(47, 49);
            this.pctBox1.Name = "pctBox1";
            this.pctBox1.Size = new System.Drawing.Size(123, 82);
            this.pctBox1.TabIndex = 5;
            this.pctBox1.TabStop = false;
            // 
            // pctBox2
            // 
            this.pctBox2.Location = new System.Drawing.Point(47, 137);
            this.pctBox2.Name = "pctBox2";
            this.pctBox2.Size = new System.Drawing.Size(123, 82);
            this.pctBox2.TabIndex = 6;
            this.pctBox2.TabStop = false;
            // 
            // pctBox3
            // 
            this.pctBox3.Location = new System.Drawing.Point(47, 225);
            this.pctBox3.Name = "pctBox3";
            this.pctBox3.Size = new System.Drawing.Size(123, 82);
            this.pctBox3.TabIndex = 7;
            this.pctBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "--";
            // 
            // BarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctBox3);
            this.Controls.Add(this.pctBox2);
            this.Controls.Add(this.pctBox1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Name = "BarView";
            this.Size = new System.Drawing.Size(222, 369);
            this.Load += new System.EventHandler(this.BarView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.PictureBox pctBox1;
        private System.Windows.Forms.PictureBox pctBox2;
        private System.Windows.Forms.PictureBox pctBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
