
public abstract class Shape2D
{
    private Position2D pos { get; set; }
    abstract public float Area { get; }
    abstract public float Circumference { get; }
    public int Sides { get; set; }
    protected string ShapeName;

    public Shape2D(string s)
    {
        this.ShapeName = s;
        this.pos = new Position2D(0, 0);
    }
}