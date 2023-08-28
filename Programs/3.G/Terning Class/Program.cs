
using System.Globalization;
using System;
using System.Security.Cryptography;

Dice die = new Dice();

Console.WriteLine("Throw: " + die.Throw());
Console.WriteLine("Throw: " + die.Throw());
Console.WriteLine("prev Value: " + die.PrevValue());
Console.WriteLine("Throw: " + die.Throw());
die.ThrowMany(10);
Console.WriteLine("many Throws: " + die.GetValueMany());


public class Dice
{
    private int value;

    private int[] throwMany;
    private Random rnd = new Random();
    private string array = "";

    public int Throw()
    {
        return value = rnd.Next(1, 6);
    }

    public int[] ThrowMany(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 6);
        }
        throwMany = arr;
        return arr;
    }
    public string GetValueMany()
    {
        foreach (int i in throwMany)
        {
            array += (i + " ");
        }
        return array;
    }
    public int PrevValue() { return value; }

}