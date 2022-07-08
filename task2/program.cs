// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] SumRow(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        arr[i] = sum;
    }
    return arr;
}

int MinSum(int[] arr)
{
    int indexMinSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[indexMinSum]) indexMinSum = i; 
    }
    return indexMinSum;
}

void PrintArr(int[] arr)
{
    foreach (int element in arr)
    {
        System.Console.Write(element + "\t");
    }
    System.Console.WriteLine();
}

int row = Prompt("enter rows count: ");
int column = Prompt("enter columns count: ");
int min = 0;
int max = 5;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
int[] arr = SumRow(array);
PrintArr(arr);
System.Console.WriteLine();
int minSum = MinSum(arr);
System.Console.WriteLine($"row with minimum sum of elements: {minSum}");
