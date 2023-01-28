//Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int sum = 0;
int number = int.Parse(Console.ReadLine()?? "0");

var digits = GetDigitsNumber(number);
for(int i = 0; i < digits.Count; i++)
{
    sum += digits[i];
}
Console.WriteLine(sum);
