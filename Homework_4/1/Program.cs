﻿// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()?? "0");
int[] arr = new int[n];
int evenCount = 0;

var r = new Random();

for(int i = 0; i < n; i++)
{
    arr[i] = r.Next(100, 1000);
}

Console.WriteLine(arr);

for(int i = 0; i < n; i++)
{
    if(arr[i] % 2 == 0);
}

Console.WriteLine($"Четных: {evenCount}");
