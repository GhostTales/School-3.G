


Dice die = new Dice();
Dice die2 = new Dice();

int sum = 0;
int sum2 = 0;
for (int i = 0; i < 10; i++)
{
    sum += die.Throw(6);
    Console.WriteLine("Die PrevValue: " + die.PrevValue());
}

for (int i = 0; i < 10; i++)
{
    sum2 += die2.Throw(6);
    Console.WriteLine("Die2 PrevValue: " + die2.PrevValue());
}

Console.WriteLine("sum fo die: " + sum);
Console.WriteLine("sum fo die2: " + sum2);

public class Dice
{
    private int value;
    private Random rnd = new Random();

    public int Throw(int n) { return value = rnd.Next(1, n); }
    public int PrevValue() { return value; }
}
