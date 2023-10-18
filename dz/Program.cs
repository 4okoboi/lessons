static long ps2_1_8 (double x, double eps)
{
    double check = Math.Sinh(x);
    long counter = 3;
    double res = x;
    long fact = 1 * 2 * 3;
    double xUp = x * x * x;
    while (Math.Abs(check - res) > eps)
    {
        if (counter % 2 != 0)
        {
            res += x_up / fact;
        }
        Console.WriteLine((res, counter));
        counter += 1;
        fact *= counter;
        xUp *= x;
    }
    return counter - 1;
}

//Console.WriteLine(ps2_1_8(3, 0.0001));

static double ps2_2_4 (double eps)
{
    double res = 2 * Math.Log(2);
    long counter = 1;
    while (Math.Abs(res - Math.PI) > eps)
    {
        res += 8 * (1.0 / ((4 * counter - 2) * (4 * counter - 1)));
        counter += 1;
    }
    return res;
}
//Console.WriteLine(ps2_2_4(0.0001));

static double left()
{
    return 0.0;
}
static double right()
{
    return 1.5;
}


static double LeftRectangleMethod(double left, double right, int n)
{
    double h = (right - left) / n; // Ширина каждого прямоугольника
    double sum = 0.0;

    for (int i = 0; i < n; i++)
    {
        double x = left + i * h; // Левая граница прямоугольника
        double fx = Math.Sqrt(Math.Tan(x)); // Значение функции на левой границе
        sum += fx * h; // Суммируем площадь текущего прямоугольника
    }

    return sum;
}

static double RightRectangleMethod(double left, double right, int n)
{
    double h = (right - left) / n; // Ширина каждого прямоугольника
    double sum = 0.0;

    for (int i = 1; i <= n; i++)
    {
        double x = left + i * h; // Правая граница прямоугольника
        double fx = Math.Sqrt(Math.Tan(x)); // Значение функции на правой границе
        sum += fx * h; // Суммируем площадь текущего прямоугольника
    }

    return sum;
}

static double TrapezoidalMethod(double left, double right, int n)
{
    double h = (right - left) / n; // Ширина каждой трапеции
    double sum = 0.0;

    for (int i = 1; i < n; i++)
    {
        double x = left + i * h; // Граница трапеции
        double fx = Math.Sqrt(Math.Tan(x)); // Значение функции на границе
        sum += 2 * fx; // Удваиваем значение функции (2*f(x))
    }

    sum += Math.Sqrt(Math.Tan(left)) + Math.Sqrt(Math.Tan(right)); // Добавляем значения на границах
    sum *= (h / 2); // Умножаем на ширину каждой трапеции

    return sum;
}

static double SimpsonMethod(double left, double right, int n)
{
    if (n % 2 != 0)
    {
        return 0;
    }

    double h = (right - left) / n; // Ширина каждого интервала
    double sum = Math.Sqrt(Math.Tan(left)) + Math.Sqrt(Math.Tan(right)); // Значения на границах

    for (int i = 1; i < n; i++)
    {
        double x = left + i * h;
        double fx = Math.Sqrt(Math.Tan(x));

        if (i % 2 == 0)
        {
            sum += 2 * fx;
        }
        else
        {
            sum += 4 * fx;
        }
    }

    sum *= (h / 3);

    return sum;
}

static double MonteCarloMethod(double left, double right, int n)
{
    Random random = new Random();
    int pointsUnderCurve = 0;

    for (int i = 0; i < n; i++)
    {
        double x = left + random.NextDouble() * (right - left); // Генерируем случайную точку в заданной области
        double y = random.NextDouble() * Math.Sqrt(Math.Tan(right)); // Генерируем случайное значение для y

        double fx = Math.Sqrt(Math.Tan(x));

        if (y <= fx)
        {
            pointsUnderCurve++;
        }
    }

    double areaUnderCurve = (double)pointsUnderCurve / n * (right - left) * Math.Sqrt(Math.Tan(right));
    return areaUnderCurve;
}

Console.WriteLine(LeftRectangleMethod(left(), right(), 10000));
Console.WriteLine(RightRectangleMethod(left(), right(), 10000));
Console.WriteLine(TrapezoidalMethod(left(), right(), 10000));
Console.WriteLine(SimpsonMethod(left(), right(), 1000000));
Console.WriteLine(MonteCarloMethod(left(), right(), 10000000));
