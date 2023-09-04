﻿using System.Reflection.Metadata.Ecma335;

Card heart = new Card('H', 13);

Console.WriteLine(heart.CardInfo());

public class Card
{
    private char name;
    private int value;

    public Card(char c, int i)
    {
        if (i > 0 && i < 14 && (c == 'H' || c == 'C' || c == 'D' || c == 'S'))
        {
            this.value = i;
            this.name = c;
        }
        else Console.WriteLine("Card value is not in range 1-13 or card name is not a valid char");

    }

    public int GetValue() { return value; }
    public char GetName() { return name; }
    private string GetNameString(char c)
    {
        if (c == 'H')
            return "Hearts";
        if (c == 'C')
            return "Clubs";
        if (c == 'D')
            return "Diamonds";
        if (c == 'S')
            return "Spades";

        else return "?";
    }
    public string CardInfo() { return $"{value} of {GetNameString(name)}"; }


}
