// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()?? "0");
int[] arr = new int[n];
int sumUnevenIndex = 0;

var r = new Random();

for(int i = 0; i < n; i++)
{
    arr[i] = r.Next(1, 100);
}

Console.WriteLine(arr);

for(int i = 0; i < n; i++)
{
    if(i % 2 != 0) sumUnevenIndex += arr[i];
}
Console.WriteLine($"Сумма {sumUnevenIndex}");
