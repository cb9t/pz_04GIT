int[] randomNums = new int[30];
int pairNums = 0;
string[] nums;

for (int i = 0; i < randomNums.Length; i++)
{
    Random number = new Random();
    randomNums[i] = number.Next(0, 322);
    if ((randomNums[i] % 2) == 0 && randomNums[i] != 0)
    {
        pairNums++;
    }
}

Console.Write($" Number of even numbers: {pairNums}");
Console.Write("\n Pair numbers:");

foreach (int n in randomNums)
    if ((n % 2) == 0 && n != 0)
    {
        Console.Write($" {n}");
        pairNums--;
        Console.Write(pairNums != 0 ? "," : ".");
    }