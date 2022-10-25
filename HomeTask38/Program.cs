// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95

void Zadacha38()
{
    int size = 12;
    double[] numbers = new double[size];

    FillArray(numbers);
    PrintArray(numbers);
    MaxNumber(numbers);
    MinNumber(numbers);
    FindDifference(numbers);

}

void FillArray(double[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-50, 50) + random.NextDouble();
    }
}
void PrintArray(double[] numbers)

{
    Console.WriteLine("Вывод массива");

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("{0,6:F2}", numbers[i], "       ");

    }
    Console.WriteLine();
}
void MaxNumber(double[] numbers)
{

    double max = numbers[0];
    for (int i = 1; i < numbers.Length; ++i)
        if (numbers[i] > max) max = numbers[i];
    Console.WriteLine("Максимальный элемент:");
    Console.WriteLine("{0,6:F2}", max);

}
void MinNumber(double[] numbers)
{

    double min = numbers[0];
    for (int i = 1; i < numbers.Length; ++i)
        if (numbers[i] < min) min = numbers[i];
    Console.WriteLine("Минимальный элемент:");
    Console.WriteLine("{0,6:F2}", min);

}
void FindDifference(double[] numbers)

{
    double difference = max - min;
    Console.WriteLine("Разница между максимальным число и минимальным равна" + difference);

}

Zadacha38();