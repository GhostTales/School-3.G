using System.Reflection;

namespace PolySolve;

public partial class Form1 : Form
{
    public TextBox Var_A = new TextBox();
    public TextBox Var_B = new TextBox();
    public TextBox Var_C = new TextBox();
    public TextBox Result = new TextBox();
    public Button Beregn = new Button();
    public Button Rens = new Button();
    public Button Afslut = new Button();
    public Polysolve? poly;
    public Form1()
    {
        InitializeComponent();

        this.Size = new Size(350, 260);

        label(10, 25, "Var A:");
        label(10, 50, "Var B:");
        label(10, 75, "Var C:");

        textbox(50, 20, "Var_A", Var_A);
        Var_A.Width = 190;
        textbox(50, 45, "Var_B", Var_B);
        Var_B.Width = 190;
        textbox(50, 70, "Var_C", Var_C);
        Var_C.Width = 190;

        label(10, 115, "Result");
        textbox(50, 110, "Result", Result);
        Result.Width = 275;
        Result.Multiline = true;
        Result.WordWrap = true;
        Result.Height = 100;
        Result.ReadOnly = true;


        button(250, 20, 75, "Beregn", Beregn);
        Beregn.Click += new EventHandler(Beregn_Click);

        button(250, 45, 75, "Rens", Rens);
        Rens.Click += new EventHandler(Rens_Click);

        button(250, 70, 75, "Afslut", Afslut);
        Afslut.Click += new EventHandler(Afslut_Click);

    }

    private void label(int X, int Y, string name)
    {
        // Creating and setting the properties of Lable1
        Label Mylablel = new Label();
        Mylablel.Location = new Point(X, Y);
        Mylablel.Text = name;
        Mylablel.AutoSize = true;
        Mylablel.BackColor = Color.LightGray;

        // Add this label to form
        this.Controls.Add(Mylablel);
    }

    private void textbox(int X, int Y, string name, TextBox Mytextbox)
    {

        // Creating and setting the properties of TextBox1
        Mytextbox.Location = new Point(X, Y);
        Mytextbox.BackColor = Color.LightGray;
        Mytextbox.ForeColor = Color.DarkOliveGreen;
        Mytextbox.AutoSize = true;
        Mytextbox.Name = name;

        // Add this textbox to form
        this.Controls.Add(Mytextbox);
    }

    private void button(int X, int Y, int W, string name, Button btn)
    {
        this.Controls.Add(btn);
        btn.Location = new Point(X, Y);
        btn.Text = name;
        btn.Width = W;
        btn.BackColor = Color.LightGray;
    }

    private void Beregn_Click(object? sender, EventArgs e)
    {
        Result.Clear();
        try
        {
            Var_A.Text = Var_A.Text.Replace(',', '.');
            Var_B.Text = Var_B.Text.Replace(',', '.');
            Var_C.Text = Var_C.Text.Replace(',', '.');

            poly = new Polysolve(float.Parse(Var_A.Text), float.Parse(Var_B.Text), float.Parse(Var_C.Text));
            Result.AppendText($"0 = {poly.Var_A}*{poly.x1}^2 + {poly.Var_B}*{poly.x2} + {poly.Var_C}");
            Result.AppendText($"{Environment.NewLine}x1 = {poly.x1} | x2 = {poly.x2}");
            Result.AppendText($"{Environment.NewLine}Discriminant = {poly.Discriminant}");

        }
        catch (System.Exception)
        {
            Result.AppendText("invalid input");
        }

    }

    private void Rens_Click(object? sender, EventArgs e)
    {
        Result.Clear();
        Var_A.Clear();
        Var_B.Clear();
        Var_C.Clear();
    }

    private void Afslut_Click(object? sender, EventArgs e)
    {
        Application.Exit();
    }

}
