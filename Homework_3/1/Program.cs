// Найти кубы чисел от 1 до N
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()?? "0");

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}