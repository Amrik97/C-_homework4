// 4) Рекурсия* https://pythontutor.ru/lessons/functions/problems/power_rec/
 Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите степень: ");
    int n = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine($"Возведение в степень: {Utility.Power(a, n)}");
    Console.WriteLine($"Возведение в степень (рекурсия): {Utility.PowerRecursion(a, n)}");