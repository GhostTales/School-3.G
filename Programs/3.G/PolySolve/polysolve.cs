public class Polysolve
{
    public float Var_A { get; set; }
    public float Var_B { get; set; }
    public float Var_C { get; set; }
    public float Discriminant { get; }
    public float x1 { get; }
    public float x2 { get; }
    public Polysolve(float A, float B, float C)
    {
        Var_A = A;
        Var_B = B;
        Var_C = C;

        this.Discriminant = Var_B * Var_B - 4 * Var_A * Var_C;

        this.x1 = (float)((-Var_B + Math.Sqrt(this.Discriminant)) / (2 * Var_A));
        this.x2 = (float)((-Var_B - Math.Sqrt(this.Discriminant)) / (2 * Var_A));
    }

}