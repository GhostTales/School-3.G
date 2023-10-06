
public abstract class Shape2D
{
    private (int, int) pos;
    public float? Area { get; set; }
    public float? Circumference { get; set; }
    public int? Sides { get; set; }
    protected string ShapeName { get; }

    public Shape2D(string s) { this.ShapeName = s; }

    public (int, int) position { get; set; }
}