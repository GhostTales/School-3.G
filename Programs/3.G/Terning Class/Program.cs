

Dice die4 = new Dice(4);
Dice die6 = new Dice(6);
Dice die8 = new Dice(8);
Dice die10 = new Dice(10);
Dice die12 = new Dice(12);
Dice die20 = new Dice(20);

Console.WriteLine($"die4: {die4.Throw()}");
Console.WriteLine($"die6: {die6.Throw()}");
Console.WriteLine($"die8: {die8.Throw()}");
Console.WriteLine($"die10: {die10.Throw()}");
Console.WriteLine($"die12: {die12.Throw()}");
Console.WriteLine($"die20: {die20.Throw()}");

Console.WriteLine(die20.info());

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
    public string info() { return $"previous value: {value} | max value of die: {max}"; }
    public int PrevValue() { return value; }
    public int MaxValue() { return max; }
}
