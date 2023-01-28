// Определить, присутствует ли в заданном массиве, некоторое число

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()?? "0");
int[] arr = new int[n];
var r = new Random();

for(int i = 0; i < n; i++)
{
    arr[i] = r.Next(0, 100);
}
Console.WriteLine(arr);

for(int i = 0; i < n; i++)
{
    if(arr[i] == number)
    {
        Console.WriteLine($"Число {number} присутствует в массиве ");
        break;
    }
}