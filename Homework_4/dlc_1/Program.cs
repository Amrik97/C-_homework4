// Кегли
// N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. 
// Затем по этому ряду бросили K шаров, при этом i-й шар сбил все кегли с номерами 
// от li до ri включительно. Определите, какие кегли остались стоять на месте.
// Программа получает на вход количество кеглей N и количество бросков K. Далее идет K пар чисел li, ri, 
// при этом 1≤ li≤ ri≤ N.

// Программа должна вывести последовательность из N символов, где j-й символ есть “I”, если j-я 
// кегля осталась стоять, или “.”, если j-я кегля была сбита.
// Ссылка https://pythontutor.ru/lessons/lists/problems/kegelbahn/

   Console.Write("Введите количество кеглей: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    char[] skittles = new char[n];

    Console.Write("Введите количество бросков: ");
    int k = int.Parse(Console.ReadLine() ?? "0");

    var lr = new int[k, 2];

    Console.WriteLine($"Введите {k} пар(ы) чисел li, ri:");
    for (int i = 0; i < k; i++)
    {
        var numbers = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
        lr[i, 0] = int.Parse(numbers[0]);
        if (!(1 <= lr[i, 0] && lr[i, 0] <= n)) lr[i, 0] = 1;
        lr[i, 1] = int.Parse(numbers[1]);
        if (!(1 <= lr[i, 1] && lr[i, 1] <= n)) lr[i, 1] = 1;

        lr[i, 0]--;
        lr[i, 1]--;
    }

    for (int i = 0; i < skittles.Length; i++)
    {
        skittles[i] = 'I';

        for (int j = 0; j < lr.GetLength(0); j++)
        {
            if (!(lr[j, 0] <= i && i <= lr[j, 1])) continue;

            skittles[i] = '.';
            break;
        }
    }

    Console.WriteLine(skittles);