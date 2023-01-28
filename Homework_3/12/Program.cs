// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()?? "0");
int[] arr = new int[n];

var r = new Random();

for (int i = 0; i < n; i++)
{
    arr[i] = r.Next(100, 1000);
}

Console.WriteLine(arr);

for(int i = 0; i < n / 2; i++)
{
    Console.WriteLine($"Произведение {i} и {n - 1 - i} элементов: {arr[i] * arr [n - 1 - i]}");
}