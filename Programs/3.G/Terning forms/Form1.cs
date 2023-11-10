namespace Terning_forms;

public partial class Form1 : Form
{

    public Button Throw = new Button();
    public PictureBox die_image = new PictureBox();
    public Dice die = new Dice(6);
    public Form1()
    {
        InitializeComponent();

        this.Controls.Add(Throw);
        Throw.Text = "Throw Dice";
        Throw.Location = new Point(10, 10);
        Throw.Click += new EventHandler(Form1_Load);

        die_image.Location = new Point(50, 50);
        die_image.SizeMode = PictureBoxSizeMode.AutoSize;

    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        die.Throw();
        Console.WriteLine(die.PrevValue());
        Image image = Image.FromFile(@$"Dice_Images\\dice_icon_{die.PrevValue()}.png");
        die_image.Image = image;
    }
}
