namespace Terning_forms
{
    partial class Form1
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
            this.DiceImageBox1 = new System.Windows.Forms.PictureBox();
            this.button_throw = new System.Windows.Forms.Button();
            this.DiceImageBox2 = new System.Windows.Forms.PictureBox();
            this.DiceImageBox3 = new System.Windows.Forms.PictureBox();
            this.DiceImageBox4 = new System.Windows.Forms.PictureBox();
            this.DiceImageBox5 = new System.Windows.Forms.PictureBox();
            this.AntalEns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // DiceImageBox1
            // 
            this.DiceImageBox1.Location = new System.Drawing.Point(47, 47);
            this.DiceImageBox1.Name = "DiceImageBox1";
            this.DiceImageBox1.Size = new System.Drawing.Size(150, 150);
            this.DiceImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiceImageBox1.TabIndex = 0;
            this.DiceImageBox1.TabStop = false;
            // 
            // button_throw
            // 
            this.button_throw.Location = new System.Drawing.Point(520, 341);
            this.button_throw.Name = "button_throw";
            this.button_throw.Size = new System.Drawing.Size(212, 64);
            this.button_throw.TabIndex = 1;
            this.button_throw.Text = "Throw die";
            this.button_throw.UseVisualStyleBackColor = true;
            this.button_throw.Click += new System.EventHandler(this.button_throw_Click);
            // 
            // DiceImageBox2
            // 
            this.DiceImageBox2.Location = new System.Drawing.Point(203, 47);
            this.DiceImageBox2.Name = "DiceImageBox2";
            this.DiceImageBox2.Size = new System.Drawing.Size(150, 150);
            this.DiceImageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiceImageBox2.TabIndex = 2;
            this.DiceImageBox2.TabStop = false;
            // 
            // DiceImageBox3
            // 
            this.DiceImageBox3.Location = new System.Drawing.Point(359, 47);
            this.DiceImageBox3.Name = "DiceImageBox3";
            this.DiceImageBox3.Size = new System.Drawing.Size(150, 150);
            this.DiceImageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiceImageBox3.TabIndex = 3;
            this.DiceImageBox3.TabStop = false;
            // 
            // DiceImageBox4
            // 
            this.DiceImageBox4.Location = new System.Drawing.Point(127, 203);
            this.DiceImageBox4.Name = "DiceImageBox4";
            this.DiceImageBox4.Size = new System.Drawing.Size(150, 150);
            this.DiceImageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiceImageBox4.TabIndex = 4;
            this.DiceImageBox4.TabStop = false;
            // 
            // DiceImageBox5
            // 
            this.DiceImageBox5.Location = new System.Drawing.Point(283, 203);
            this.DiceImageBox5.Name = "DiceImageBox5";
            this.DiceImageBox5.Size = new System.Drawing.Size(150, 150);
            this.DiceImageBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiceImageBox5.TabIndex = 5;
            this.DiceImageBox5.TabStop = false;
            // 
            // AntalEns
            // 
            this.AntalEns.AutoSize = true;
            this.AntalEns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AntalEns.Location = new System.Drawing.Point(517, 292);
            this.AntalEns.Name = "AntalEns";
            this.AntalEns.Size = new System.Drawing.Size(0, 20);
            this.AntalEns.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AntalEns);
            this.Controls.Add(this.DiceImageBox5);
            this.Controls.Add(this.DiceImageBox4);
            this.Controls.Add(this.DiceImageBox3);
            this.Controls.Add(this.DiceImageBox2);
            this.Controls.Add(this.button_throw);
            this.Controls.Add(this.DiceImageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceImageBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DiceImageBox1;
        private System.Windows.Forms.Button button_throw;
        private System.Windows.Forms.PictureBox DiceImageBox2;
        private System.Windows.Forms.PictureBox DiceImageBox3;
        private System.Windows.Forms.PictureBox DiceImageBox4;
        private System.Windows.Forms.PictureBox DiceImageBox5;
        private System.Windows.Forms.Label AntalEns;
    }
}

