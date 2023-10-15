public class Square2D : Rectangle2D
{
    private int Width;


    public Square2D(int w) : base(w, w)
    {
        this.ShapeName = "Square";
        this.Width = w;
    }

    public override float Area { get { return this.Width * this.Width; } }
    public override float Circumference { get { return this.Width * 4; } }
}