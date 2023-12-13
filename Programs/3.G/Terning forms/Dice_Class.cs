using System;

public class Dice
{
    private int value;
    private Random rnd = new Random();
    private int max;

    public Dice(int n)
    {
        this.max = n;
    }

    public int Throw() { return value = rnd.Next(1, max + 1); }
    public string info() { return $"previous value: {value} | max value of die: {max}"; }
    public int PrevValue() { return value; }
    public int MaxValue() { return max; }
}
