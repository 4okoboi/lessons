Random random = new Random();
int n = 9;
int[,] matr = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matr[j, i] = random.Next(3);
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matr[i, j],3}");
    }
    Console.WriteLine();
}
int s1 = 0;
int s2 = 0;
int s3 = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0 || i == n - 1)
        {
            s1 += matr[i, j];
        } else if (j == 0 || j == n - 1)
        {
            s1 += matr[i, j];
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j || i == n - j)
        {
            s2 += matr[i, j];
        }
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j >= i && j >= n - i)
        {
            s3 += matr[i, j];
        } else if (j <= i && j <= n - i)
        {
            s3 += matr[i, j];
        }
    }
}

Console.WriteLine($"5 - {s1}, 6 - {s2}, 7 - {s3}");