﻿//Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива.

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

int[,] ReorderRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] > array[i, k + 1]) 
                {
                    int temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
                }
            }
        }
    }

    return array;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int row = 5;
int column = 5;
int min = 0;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
System.Console.WriteLine();
int[,] arr = ReorderRowArray(array);
PrintArr(arr);



