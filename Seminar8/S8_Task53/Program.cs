// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

const int Rows = 5;
const int Columns = 4;
int[,] GetRandomMatrix(int rows, int columns)
{
    int[,]matrix = new int [rows , columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(1, 10);
        }
    }    

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j <  matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);

void SwapFirstAndLastRows (int[,] array)
{
    int rowCount = array.GetLength(0);
    int ColumnCount = array.GetLength(1);
    for (int j = 0; j < ColumnCount; j++)
    {
int temp = array[0 , j];
    array [0,j] = array [rowCount - 1, j];
    array [rowCount - 1, j] = temp;
    }
}
SwapFirstAndLastRows(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);
