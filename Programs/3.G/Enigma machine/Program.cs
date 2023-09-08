


Rotor wheel_I = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ");
Rotor wheel_II = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE");
Rotor wheel_III = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO");

Console.WriteLine($"{wheel_I.Get_pos()} | I");

for (int i = 0; i < wheel_I.length + 1; i++)
{
    wheel_I.Tick();
}

Console.WriteLine($"{wheel_I.Get_pos()} | I");

if (wheel_I.max == true) { wheel_II.Tick(); wheel_I.max = false; }

Console.WriteLine($"{wheel_II.Get_pos()} | II");


class Rotor
{
    private string str;
    private char[] ch;
    private int tick;
    public bool max;
    public int length;

    public Rotor(string s)
    {
        str = s;
        this.tick = 0;
        this.ch = str.ToCharArray();
        this.length = ch.Length;
    }

    public void Tick()
    {
        tick++;

        if (tick == 26) { tick = 0; max = true; }
    }

    public char Get_pos()
    {
        return ch[tick];
    }


}
