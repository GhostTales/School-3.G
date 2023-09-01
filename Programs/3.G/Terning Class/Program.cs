

Dice die20 = new Dice(20);

Console.WriteLine($"die20: {die20.Throw()}");


public class Dice
{
    private int value;
    private Random rnd = new Random();
    private int max;

    public Dice(int n)
    {
        rnd = new Random();
        this.max = n;
    }

    public int Throw() { return value = rnd.Next(1, max + 1); }
    public int PrevValue() { return value; }
    public int MaxValue() { return max; }
}
