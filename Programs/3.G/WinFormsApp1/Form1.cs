namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            TextResult.Text = (ParseF(TextInput1.Text) + ParseF(TextInput2.Text)).ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            TextResult.Text = (ParseF(TextInput1.Text) - ParseF(TextInput2.Text)).ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            TextResult.Text = (ParseF(TextInput1.Text) * ParseF(TextInput2.Text)).ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            TextResult.Text = (ParseF(TextInput1.Text) / ParseF(TextInput2.Text)).ToString();
        }

        private float ParseF(string s) 
        {
            return float.Parse(s);
        }
    }
}