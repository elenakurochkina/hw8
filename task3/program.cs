//Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.

int[,] ArrA(int row, int column, int min, int max)
{
    var arrA = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrA.GetLength(1); j++)
        {
            arrA[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arrA;
}

int[,] ArrB(int row, int column, int min, int max)
{
    var arrB = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < arrB.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            arrB[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arrB;
}

int[,] MultTwoMatrix(int[,] arrA, int[,] arrB, int row, int column)
{
    //var arrMult = new int[row, column];
    //var rnd = new Random();
    //int[,] arrA = new int[2, 2];
    int[,] arrMult = new int[row, column];
        for (int i = 0; i < arrA.GetLength(0); i++)
{
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                arrMult[i, j] += arrA[i, k] * arrB[k, j];
            }
        }
    }
    return arrMult;
}

void PrintArray(int[,] arrMult)
{
    for (int i = 0; i < arrMult.GetLength(0); i++)
    {
        for (int j = 0; j < arrMult.GetLength(1); j++)
        {
            System.Console.Write(arrMult[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArrA(int[,] arrA)
{
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrA.GetLength(1); j++)
        {
            System.Console.Write(arrA[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArrB(int[,] arrB)
{
    for (int i = 0; i < arrB.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            System.Console.Write(arrB[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int row = 3;
int column = 3;
int min = 1;
int max = 3;
int[,] arrA = ArrA(row, column, min, max);
PrintArrA(arrA);
System.Console.WriteLine();
int[,] arrB = ArrB(row, column, min, max);
PrintArrB(arrB);
System.Console.WriteLine();
int[,] arrMult = MultTwoMatrix(arrA, arrB, row, column);
PrintArray(arrMult);
