// 3) Двумерные массивы https://pythontutor.ru/lessons/2d_arrays/problems/snowflake/
 Console.Write("Введите нечетное число: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    char[,] star = new char[n, n];

    int center = n / 2;

    for (int i = 0; i < star.GetLength(0); i++)
    {
        for (int j = 0; j < star.GetLength(1); j++)
        {
            if (i == center || j == center)
            {
                star[i, j] = '*';
                continue;
            }

            if (i == j || i == (n - 1) - j)
            {
                star[i, j] = '*';
                continue;
            }

            star[i, j] = '.';
        }
    }

    Console.WriteLine(star);