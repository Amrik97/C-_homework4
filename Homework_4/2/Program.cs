// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19 
//[-4, -6, 89, 6] -> 0

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine()??"0");
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
    if((i + 1) % 2 != 0) sumUnevenIndex += arr[i];
}

Console.WriteLine($"Сумма {sumUnevenIndex}");