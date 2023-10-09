public class Rectangle2D : Shape2D
{
    private new int Sides;
    private int Width;
    private int Height;
    public override float Area { get { return this.Width * this.Height; } }
    public override float Circumference { get { return this.Width * 2 + this.Height * 2; } }

    public Rectangle2D(int w, int h) : base("Rectangle")
    {
        this.Width = w;
        this.Height = h;
        this.Sides = 4;

    }
}