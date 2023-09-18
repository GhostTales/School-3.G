Deck set = new Deck(true);
set.Shuffle(100);


for (int i = 0; i < 52; i++)
{
    Console.WriteLine(set.Draw().CardInfo());
}


Console.WriteLine("###################################");


for (int i = 0; i < set.NumOfCards(); i++)
{
    Console.WriteLine(set.GetCardInSet(i).CardInfo());
}

Console.WriteLine("###################################");

set.NewDeck();

for (int i = 0; i < set.NumOfCards(); i++)
{
    Console.WriteLine(set.GetCardInSet(i).CardInfo());
}

Console.WriteLine("###################################");