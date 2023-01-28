 // Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число: ");
int res = 1;
int number = int.Parse(Console.ReadLine()?? "0");

for(int i = 1; i <= number; i++)
{
    res *= 1;
}
Console.WriteLine(res);