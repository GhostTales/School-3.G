
public abstract class Shape2D
{
    private Position2D Pos { get; set; }
    abstract public float Area { get; }
    abstract public float Circumference { get; }
    protected string ShapeName;

    public Shape2D(string s)
    {
        this.ShapeName = s;
        this.Pos = new Position2D(0, 0);
    }
}