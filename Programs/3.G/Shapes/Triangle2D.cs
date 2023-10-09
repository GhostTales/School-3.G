public class Triangle2D : Shape2D
{
    private int Width;
    private int Height;

    public override float Area { get { return this.Width * this.Height * 0.5f; } }
    public override float Circumference { get { return this.Width + 2 * (float)Math.Sqrt(Math.Pow(this.Width, 2) + Math.Pow(this.Height, 2)); } }

    public Triangle2D(int w, int h) : base("Triangle")
    {

    }
}