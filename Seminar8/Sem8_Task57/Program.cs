// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
// Элементы [0, 9]

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

int [] GetFrequencyOfElements (int [,] mySecondArray)
{
    int[] frequencyArray = new int [10];
    int rowCount = mySecondArray.GetLength(0);
    int columnCount = mySecondArray.GetLength(1);
    for (int i = 0; i < rowCount; i++)
        for (int j = 0; j < columnCount; j++)
        {
            frequencyArray[mySecondArray[i,j]]++;
        }
    return frequencyArray;
}


int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
Console.WriteLine();
int [] frequency = GetFrequencyOfElements(myMatrix);
for (int i = 0; i < frequency.Length; i++)
{
Console.WriteLine($" Number {i} appears {frequency[i]} times");
} 
 