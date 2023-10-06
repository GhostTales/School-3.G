public class Circle : Shape2D
{

    public new int Sides { get { return 0; } set { } }
    public Circle(string s) : base(s) { }

    public float Radius { get; set; }

    public new float? Circumference
    {
        get { return (float)(2 * Radius * Math.PI); }
    }

    public new float? Area
    {
        get { return (float)(Math.Pow(Radius, 2) * Math.PI); }
    }

    public string info()
    {
        return $"sides: {this.Sides}, radius: {this.Radius}, area: {this.Area}, circumference: {this.Circumference}";
    }
}