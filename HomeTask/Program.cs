﻿// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Zadacha34()
{
    int size = 12;
    int[] numbers = new int[size];

    FillArray(numbers);
    PrintArray(numbers);
    PlusNumbers(numbers);
}

void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100, 1000);
    }
}
void PrintArray(int[] numbers)

{
    Console.WriteLine("Вывод массива");

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");

    }
    Console.WriteLine();
}

void PlusNumbers(int[] numbers)

{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        count++;
    }
    Console.WriteLine ($"Количество четных чисел в массиве = {count}");
}

Zadacha34 ();