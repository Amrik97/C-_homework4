// Найти сумму чисел от 1 до А
Console.Write("Введите число: ");
int sum = 0;
int number = int.Parse(Console.ReadLine()?? "0");

for (int i = 1; i <= number; i++)
{
    sum += i;
}
Console.WriteLine(sum);