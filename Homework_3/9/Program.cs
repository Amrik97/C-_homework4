// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()?? "0");
int[] arr = new int[n];
int evenCount = 0;
int unevenCount = 0;

var r = new Random();

for(int i = 0; i < n; i++)
{
    arr[i] = r.Next(100, 1000);
}

Console.WriteLine(arr);

for(int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0) evenCount++;
    else unevenCount++;
}

Console.WriteLine($"Четных: {evenCount}\nНечетных {unevenCount}");
