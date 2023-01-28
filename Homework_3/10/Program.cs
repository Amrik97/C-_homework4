// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите начало интервала: ");
int a = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите конец интервала: ");
int b = int.Parse(Console.ReadLine()?? "0");
int[] arr = new int [n];
int countElementInterval = 0;

var r = new Random();

for (int i = 0; i < n; i++)
{
    arr[i] = r.Next(a / 2, b * 2 + 1);
}

Console.WriteLine(arr);

for (int i = 0; i < n; i++)
{
    if(a <= arr[i] && arr[i] <= b) countElementInterval++;
}

Console.WriteLine($"Количество элементов в интервале: {countElementInterval}");
