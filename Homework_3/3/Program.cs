// Возведите число А в натуральную степень B используя цикл
Console.Write("Введите число: ");
int res = 1;
int number = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите степень: ");
int pow = int.Parse(Console.ReadLine()?? "0");

for(int i = 1; i <= pow; i++)
{
    res *= number;
}

Console.WriteLine(res);