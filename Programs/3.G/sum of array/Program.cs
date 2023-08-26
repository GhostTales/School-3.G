// See https://aka.ms/new-console-template for more information


int[] nummbers = { 1, 2, 3, 4, 5 };

int Summen(int[] arr, int i)
{

    if (i <= 1)
        return arr[0];

    return Summen(arr, i - 1) + arr[i - 1];



}

Console.WriteLine(Summen(nummbers, nummbers.Length));