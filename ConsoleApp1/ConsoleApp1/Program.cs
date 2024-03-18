// See https://aka.ms/new-console-template for more information

Console.WriteLine("Modification 1");
Console.WriteLine("Modification 3");

static int ArrAverage(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        res = res + arr[i];
    }
    return res;
}

static int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
