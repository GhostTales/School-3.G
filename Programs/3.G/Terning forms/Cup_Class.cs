using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

public class Cup
{
    private int max_nod; // number_of_dice
    private int max_value; // dice size
    Dice[] dice;


    public Cup(int nod, int max)
    {
        this.max_nod = nod;
        this.max_value = max;

        dice = new Dice[this.max_nod];
    }

    public Dice[] Get_Result() { return dice; }

    public void throw_Dice()
    {
        for (int i = 0; i < max_nod; i++)
        {
            dice[i] = new Dice(max_value);
            Thread.Sleep(1);
            dice[i].Throw();
        }
    }

    public string Yatsy() 
    {
        List<int> list = new List<int>();
        for (int i = 0; i < max_nod+1; i++)
        {
            var ens = 0;

            foreach (Dice d in this.dice)
                if (d.PrevValue() - 1 == i) ens++;

            list.Add(ens);
        }

        string AntalEens = "0 ens";

        foreach (var item in list)
        {
            if (item > 1) AntalEens = $"{item} ens";
        }

        return AntalEens;
    }



 
}