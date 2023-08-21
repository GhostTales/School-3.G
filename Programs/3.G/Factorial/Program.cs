// See https://aka.ms/new-console-template for more information

int Fakultet(int i)
{
    if (i < 0)
        return 0;
    if (i == 0)
        return 1;
    if (i == 1)
        return i;

    return i * Fakultet(i - 1);
}

Console.WriteLine(Fakultet(32));