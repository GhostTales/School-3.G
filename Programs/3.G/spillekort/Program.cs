Deck set = new Deck(true);
set.Shuffle(100);


for (int i = 0; i < 52; i++)
{
    Console.WriteLine(set.Draw().CardInfo());
}


Console.WriteLine("###################################");

if (set.Insert(new Card('H', 13)) == true)
    Console.WriteLine("insert succes");

else Console.WriteLine("insert fail");

Console.WriteLine("###################################");

for (int i = 0; i < set.NumOfCards(); i++)
{
    Console.WriteLine(set.GetCardInSet(i).CardInfo());
}

Console.WriteLine("###################################");

if (set.Insert(new Card('H', 12)) == true)
    Console.WriteLine("insert succes");

else Console.WriteLine("insert fail");