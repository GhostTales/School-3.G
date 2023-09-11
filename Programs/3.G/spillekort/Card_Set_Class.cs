public class Card_set
{
    private int value_max = 13;
    private char[] types = { 'H', 'C', 'D', 'S' };
    public Card[] set = new Card[52];
    private int t;
    private string string_set = "";

    public Card[] CreateSet()
    {
        for (int i = 0; i < types.Length; i++)
        {
            for (int n = 1; n <= value_max; n++)
            {
                set[t] = new Card(types[i], n);
                t++;
            }
        }

        return set;
    }

    public String GetCardSet()
    {
        for (int i = 0; i < set.Length; i++)
        {
            string_set += $"({set[i].CardInfo()}) ";
        }

        return string_set;
    }
}