List<int> Temps = new List<int>();
Console.Write("Enter the List Values : ");
string input = Console.ReadLine().Trim();

foreach (var ch in input.Split(","))
{
    Temps.Add(Convert.ToInt32(ch));
}

int findnextsmaller(int idx, int val)
{
    for (int i = idx + 1; i < Temps.Count; i++)
    {
        if (Temps[i] < val)
        {
            return i - idx;
        }
    }
    return 0;
}

List<int> Fresult = new List<int>();
for (int from = 0; from < Temps.Count; from++)
{
    Fresult.Add(findnextsmaller(from, Temps[from]));
}

Console.Write("[");
for (int n = 0; n < Fresult.Count; n++)
{
    if (n != Fresult.Count - 1) { Console.Write($"{Fresult[n]},"); }
    else { Console.Write($"{Fresult[n]}"); }
}
Console.Write("]");