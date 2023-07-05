// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 

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

int [,] SwapRowsAndColumns (int[,] array) //ffgf
{
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);
    int[,] swapArray = new int [columnCount, rowCount];
    for (int i = 0; i < rowCount; i++)
    {
         for (int j = 0; j < columnCount; j++)
        {
            swapArray[j, i] = array[i, j];
        }
    }    
    return swapArray;
} 
 
int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] swapMatrix = SwapRowsAndColumns(myMatrix);
PrintMatrix(swapMatrix);