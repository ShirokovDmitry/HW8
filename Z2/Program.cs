// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, {8, 4, 20, 4 }, {5, 2, 6, 7} };
Console.WriteLine("Задан массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}
int min = 0;
int minSum = 0;
int sum = 0;
for (int i = 0; i < arr.GetLength(1); i++)
{
    min += arr[0, i];
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++) 
        sum += arr[i, j];
        Console.WriteLine($"В {i + 1} строке {sum}");
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
}
Console.WriteLine($"Наименьшая сумма: В {minSum + 1} строке.");
