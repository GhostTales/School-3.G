
public class Deck
{
    private int value_max = 13;
    private char[] types = { 'H', 'C', 'D', 'S', 'J' };
    private List<Card> set = new List<Card>();
    private Random rnd = new Random();
    private Card? temp;
    private int temp_int;
    private int temp_int2;
    private bool GetJokerEnabled;


    public Deck(bool joker)
    {
        GetJokerEnabled = joker;

        if (GetJokerEnabled != true)
        {
            for (int i = 0; i < types.Length - 1; i++)
            {
                for (int n = 1; n <= value_max; n++)
                {
                    set.Add(new Card(types[i], n));
                }
            }
        }
        else if (GetJokerEnabled == true)
        {
            for (int i = 0; i < types.Length - 1; i++)
            {
                for (int n = 1; n <= value_max; n++)
                {
                    set.Add(new Card(types[i], n));
                }
            }
            for (int i = 1; i < types.Length; i++)
            {
                set.Add(new Card(types[4], i));
            }
        }
    }

    public Card GetCardInSet(int n) { return set[n]; }

    public void Shuffle(int n)
    {
        for (int i = 0; i < n; i++)
        {
            temp_int = rnd.Next(0, set.Count);
            temp_int2 = rnd.Next(0, set.Count);
            temp = set[temp_int];
            set[temp_int] = set[temp_int2];
            set[temp_int2] = temp;

        }
    }

    public Card Draw()
    {
        temp = set[set.Count - 1];
        set.RemoveAt(set.Count - 1);
        return temp;
    }

    public void NewDeck()
    {
        set.Clear();
        if (GetJokerEnabled != true)
        {
            for (int i = 0; i < types.Length - 1; i++)
            {
                for (int n = 1; n <= value_max; n++)
                {
                    set.Add(new Card(types[i], n));
                }
            }
        }
        else if (GetJokerEnabled == true)
        {
            for (int i = 0; i < types.Length - 1; i++)
            {
                for (int n = 1; n <= value_max; n++)
                {
                    set.Add(new Card(types[i], n));
                }
            }
            for (int i = 1; i < types.Length; i++)
            {
                set.Add(new Card(types[4], i));
            }
        }
    }

    public int NumOfCards() { return set.Count; }

    public bool Insert(Card c)
    {
        if (set.Exists(card => c.CardInfo == card.CardInfo)) { return false; }

        set.Insert(rnd.Next(1, set.Count + 1), c);
        return true;
    }
}

