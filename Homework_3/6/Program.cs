// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()?? "0");

for(int i = 1; i <= number; i++)
{
    if(Math.Pow(i, 3) % 10 == 2)
    Console.WriteLine(i);
}
