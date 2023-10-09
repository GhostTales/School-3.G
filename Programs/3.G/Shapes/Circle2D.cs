public class Circle2D : Shape2D
{
    private float Radius;
    public Circle2D(float r) : base("Circle")
    {
        this.Radius = r;
    }

    public override float Area
    {
        get { return (float)(Math.Pow(Radius, 2) * Math.PI); }
    }

    public override float Circumference
    {
        get { return (float)(2 * Radius * Math.PI); }
    }
}