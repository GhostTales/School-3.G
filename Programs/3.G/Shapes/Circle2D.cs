public class Circle2D : Shape2D
{

    private new int Sides;
    public Circle2D(float r) : base("Circle")
    {
        this.Sides = 0;
        this.Radius = r;
    }

    public float Radius { get; set; }

    public override float Circumference
    {
        get { return (float)(2 * Radius * Math.PI); }
    }

    public override float Area
    {
        get { return (float)(Math.Pow(Radius, 2) * Math.PI); }
    }

}