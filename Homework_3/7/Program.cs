// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()?? "0");
int[] arr = new int[n];
var r = new Random();

for (int i = 0; i < n; i++)
{
    arr[i] = r.Next(0, 2);
}
Console.WriteLine(arr);