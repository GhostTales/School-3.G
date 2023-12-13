using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terning_forms
{
    public partial class Form1 : Form
    {
        Image[] images = new Image[6];
        Cup cup = new Cup(5, 6);
        

        public Form1()
        {
            InitializeComponent();
            LoadImages();
        }

        public void LoadImages() 
        {
            images[0] = Properties.Resources.dice_icon_1;
            images[1] = Properties.Resources.dice_icon_2;
            images[2] = Properties.Resources.dice_icon_3;
            images[3] = Properties.Resources.dice_icon_4;
            images[4] = Properties.Resources.dice_icon_5;
            images[5] = Properties.Resources.dice_icon_6;
        }

        public void UpdateGUI() 
        {
            DiceImageBox1.Image = images[cup.Get_Result()[0].PrevValue() - 1];
            DiceImageBox2.Image = images[cup.Get_Result()[1].PrevValue() - 1];
            DiceImageBox3.Image = images[cup.Get_Result()[2].PrevValue() - 1];
            DiceImageBox4.Image = images[cup.Get_Result()[3].PrevValue() - 1];
            DiceImageBox5.Image = images[cup.Get_Result()[4].PrevValue() - 1];
            AntalEns.Text = cup.Yatsy();
        }

        private void button_throw_Click(object sender, EventArgs e)
        {
            cup.throw_Dice();
            UpdateGUI();
            Debug.WriteLine(cup.Yatsy());
        }
    }
}
