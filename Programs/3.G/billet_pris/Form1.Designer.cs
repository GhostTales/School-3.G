namespace billet_pris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrisLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Pensionist = new System.Windows.Forms.CheckBox();
            this.FraCombobox = new System.Windows.Forms.ComboBox();
            this.DestinationComboBox = new System.Windows.Forms.ComboBox();
            this.Udskriv_Billet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beregning af billetpris";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fra";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(374, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(30, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gyldig indtil:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(121, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kl. xx.xx d. xx.xx.xx";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(358, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pris";
            // 
            // PrisLabel
            // 
            this.PrisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrisLabel.AutoSize = true;
            this.PrisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PrisLabel.Location = new System.Drawing.Point(396, 188);
            this.PrisLabel.Name = "PrisLabel";
            this.PrisLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PrisLabel.Size = new System.Drawing.Size(36, 17);
            this.PrisLabel.TabIndex = 6;
            this.PrisLabel.Text = "xx.xx";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(438, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kr.";
            // 
            // Pensionist
            // 
            this.Pensionist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pensionist.AutoSize = true;
            this.Pensionist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Pensionist.Location = new System.Drawing.Point(33, 128);
            this.Pensionist.Name = "Pensionist";
            this.Pensionist.Size = new System.Drawing.Size(92, 21);
            this.Pensionist.TabIndex = 9;
            this.Pensionist.Text = "Pensionist";
            this.Pensionist.UseVisualStyleBackColor = true;
            this.Pensionist.CheckedChanged += new System.EventHandler(this.Pensionist_CheckedChanged);
            // 
            // FraCombobox
            // 
            this.FraCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FraCombobox.FormattingEnabled = true;
            this.FraCombobox.Items.AddRange(new object[] {
            "Andebyvej 44 \t5",
            "DonnerWetterVej 4 \t3",
            "Esbjerg havnefront 18 \t9 ",
            "FCM Arena \t5",
            "Fr.Havn station \t2",
            "GærumsPizza Distro \t1",
            "GunnarGrumsvej \t6",
            "HTX Håndbækvej 50 \t1",
            "KirstenDonhammersvej 18 \t4",
            "KlipfiskArnesvej 222 \t7",
            "Tåneglsallé 13 \t7",
            "Viborg vandværk 35 \t8"});
            this.FraCombobox.Location = new System.Drawing.Point(33, 88);
            this.FraCombobox.Name = "FraCombobox";
            this.FraCombobox.Size = new System.Drawing.Size(275, 24);
            this.FraCombobox.TabIndex = 10;
            // 
            // DestinationComboBox
            // 
            this.DestinationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DestinationComboBox.FormattingEnabled = true;
            this.DestinationComboBox.Items.AddRange(new object[] {
            "HTX Håndbækvej 50 \t1",
            "GærumsPizza Distro \t1",
            "Fr.Havn station \t2",
            "DonnerWetterVej 4 \t3",
            "KirstenDonhammersvej 18 \t4",
            "Andebyvej 44 \t5",
            "FCM Arena \t5",
            "GunnarGrumsvej \t6",
            "KlipfiskArnesvej 222 \t7",
            "Tåneglsallé 13 \t7",
            "Viborg vandværk 35 \t8",
            "Esbjerg havnefront 18 \t9 "});
            this.DestinationComboBox.Location = new System.Drawing.Point(377, 88);
            this.DestinationComboBox.Name = "DestinationComboBox";
            this.DestinationComboBox.Size = new System.Drawing.Size(290, 24);
            this.DestinationComboBox.TabIndex = 11;
            // 
            // Udskriv_Billet
            // 
            this.Udskriv_Billet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Udskriv_Billet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Udskriv_Billet.Location = new System.Drawing.Point(495, 160);
            this.Udskriv_Billet.Name = "Udskriv_Billet";
            this.Udskriv_Billet.Size = new System.Drawing.Size(172, 60);
            this.Udskriv_Billet.TabIndex = 12;
            this.Udskriv_Billet.Text = "Udskriv Billet";
            this.Udskriv_Billet.UseVisualStyleBackColor = true;
            this.Udskriv_Billet.Click += new System.EventHandler(this.Udskriv_Billet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 232);
            this.Controls.Add(this.Udskriv_Billet);
            this.Controls.Add(this.DestinationComboBox);
            this.Controls.Add(this.FraCombobox);
            this.Controls.Add(this.Pensionist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PrisLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PrisLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Pensionist;
        private System.Windows.Forms.ComboBox FraCombobox;
        private System.Windows.Forms.ComboBox DestinationComboBox;
        private System.Windows.Forms.Button Udskriv_Billet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

