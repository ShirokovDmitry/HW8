// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arr = { {2, 4}, { 3, 2} };
Console.WriteLine("Матрица 1: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}
int[,] arr2 = { {3, 4}, { 3, 3} };
Console.WriteLine("Матрица 2: ");
for (int i = 0; i < arr2.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        Console.Write($"{arr2[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("Результирующая матрица:");
int[,] finalArr = new int[arr.GetLength(0), arr2.GetLength(1)];
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int n = 0; n < arr2.GetLength(0); n++)
            {
                finalArr[i,j] += arr[i,n] * arr2[n,j];
            }
            Console.Write($"{finalArr[i, j]} \t");
        }
        Console.WriteLine();
    }
}


