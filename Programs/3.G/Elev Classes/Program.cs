
using System;
using Microsoft.VisualBasic;

Elev[] elever = new Elev[100];

for (int i = 0; i < elever.Length; i++)
{
    elever[i] = new Elev();
}

Elev minElev = new Elev();
Elev minElev2 = new Elev();
Elev minElev3 = new Elev();
Elev minElev4 = new Elev();


minElev.SetNavn("Dan");
minElev.SetAlder(19);
minElev.SetSnit(7.8f);

minElev2.SetAll("Thomas", 48, 7.7f);
minElev3.SetAll("Søren", 18, 7.6f);
minElev4.SetAll("Jens", 20, 7.9f);


minElev.ElevInfo();
minElev2.ElevInfo();
minElev3.ElevInfo();
minElev4.ElevInfo();

public class Elev
{
    private int alder;
    private string navn = "";
    private float snit;

    public void SetAlder(int n) { alder = n; }
    public int GetAlder() { return alder; }
    public void SetNavn(string s) { navn = s; }
    public string GetNavn() { return navn; }
    public void SetSnit(float f) { snit = f; }
    public float GetSnit() { return snit; }

    public void ElevInfo()
    {
        Console.WriteLine("Alder: " + this.GetAlder());
        Console.WriteLine("Navn: " + this.GetNavn());
        Console.WriteLine("Gennemsnit " + this.GetSnit());
        Console.WriteLine("----------------------------");
    }

    public void SetAll(string s, int n, float f)
    {
        this.SetNavn(s);
        this.SetAlder(n);
        this.SetSnit(f);
    }
}