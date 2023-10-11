//PS1 1 часть - 7

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if ((a + b) < c && (a + c) < b && (b + c) < a {
//    Console.WriteLine("Является треугольником");
//}
//else
//{
//    Console.WriteLine("Не является треугольником");
//}





//PS1 2 часть - 18

//int a = int.Parse(Console.ReadLine());
//string res = "";
//string alph = "0123456789ABCDEF";

//if (a == 0)
//{
//    Console.WriteLine(0);
//    Environment.Exit(0);
//}
//while (a > 0)
//{
//    res = alph[a % 16] + res;
//    a = a / 16;
//}
//Console.WriteLine(res);





//PS1 3 часть - 9

//int n = int.Parse(Console.ReadLine());
//bool f = true;
//int[] arr = new int[n];

//for (int i = 0; i < n; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0; i < n - 1; i++)
//{
//    if (i % 2 == 0)
//    {
//        continue;
//    }
//    if (arr[i] < 0 && arr[i + 1] > 0) {

//    } else if (arr[i] > 0 && arr[i + 1] < 0)
//    {

//    } else
//    {
//        f = false;
//        Console.WriteLine("Не знакопеременный");
//        break;
//    }
//}

//if (f)
//{
//    Console.WriteLine("Знакопеременный");
//}





//P3 4 часть - 20
//int A = 0, B = 0, C = 0;


//for (int a = 1; a < 1000; a++)
//{
//    for (int b = 1; b < 1000; b++)
//    {
//        for (int c = 1; c < 1000; c++)
//        {
//            if (a + b + c == 1000 && a * a + b * b == c * c)
//            {
//                (A, B, C) = (a, b, c);
//                break;
//            } 
//        }
//    }
//}

//Console.WriteLine(A * B * C); // 31875000
