// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

const int Rows = 5;
const int Columns = 4;
int[,] GetRandomMatrix(int rows, int columns)
{
    int[,]matrix = new int [rows , columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(0, 10);
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
Console.WriteLine("Initial Matrix:");
PrintMatrix(myMatrix);
Console.WriteLine();

int [] GetPositinMin(int [,] Matrix)
{
int iPositionMin = 0;
int jPositionMin = 0;
int min = Matrix [0,0];
for (int i = 0; i < Matrix.GetLength(0); i++)
    for (int j = 0; j < Matrix.GetLength(1); j++)
    { 
        if (Matrix [i,j] < min)
        {
           min = Matrix [i,j];
           iPositionMin = i;
           jPositionMin = j;
        }   
    }
    return new int []{iPositionMin, jPositionMin};
}

int [] arrayMin = GetPositinMin(myMatrix);
Console.WriteLine($"Cross point is {String.Join("  ",arrayMin)}");
Console.WriteLine();

int [,] RemoveOneColumnAndRow (int [,] matrix, int [] arrayToRemove)
{
    int[,] matrixReduced = new int [matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int iShift = 0;
    int jShift = 0;
    for (int i = 0; i < matrixReduced.GetLength(0); i++)
    {
        if (i == arrayToRemove [0])
                iShift++;
        for (int j = 0; j < matrixReduced.GetLength(1); j++)
        {
                if (j == arrayToRemove [1])
                jShift++;
                matrixReduced[i,j]= matrix [i+iShift, j+jShift ];
        }
        jShift = 0;
}
  return matrixReduced;
}

int [,] matrReduced = RemoveOneColumnAndRow (myMatrix, arrayMin);
Console.WriteLine("New Matrix:");
PrintMatrix(matrReduced);