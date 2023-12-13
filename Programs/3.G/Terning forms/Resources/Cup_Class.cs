public class Cup
{
    private int max_nod; // number_of_dice
    private int max_value; // dice size
    private Random rnd = new Random();
    private string result = "";
    Dice[] dice;
    Dice temp;

    public Cup(int nod, int max)
    {
        this.max_nod = nod;
        this.max_value = max;

        dice = new Dice[this.max_nod];

        for (int i = 0; i < max_nod; i++)
        {
            temp = new Dice(max_value);
            temp.Throw();
            dice[i] = temp;
        }
    }

    public string Get_Result()
    {
        for (int i = 0; i < max_nod; i++)
        {
            result += $"{dice[i].info()}\n";
        }
        return result;
    }
}