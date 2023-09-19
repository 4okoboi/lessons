int num;
num = int.Parse(Console.ReadLine());

static string IsPowOfThree(int n)
{
    for (int i = 1; i <= n; i *= 3)
    {
        if (n == i)
        {
            return ("Число является степенью тройки");
        }
    }

    return ("Число не является степенью тройки");
}

Console.WriteLine(IsPowOfThree(num));