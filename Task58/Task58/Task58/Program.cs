//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


using System;
using Task58;
ArrayWorker worker = new ArrayWorker();
int[,] array1 = worker.GetArray(2, 2);
int[,] array2 = worker.GetArray(2, 2);
int[,] array3 = new int[2, 2];
worker.PrintArray(array1);
Console.WriteLine();
worker.PrintArray(array2);
Console.WriteLine();
worker.CompositionMatrix(array1, array2, array3);
worker.PrintArray(array3);
