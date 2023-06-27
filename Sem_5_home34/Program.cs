//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GetRandomArray()
{
int[] array = new int[4];
for (int i = 0; i<array.Length; i++)
{
    array[i] = Random.Shared.Next(99, 1000);
}
return array;
}
int[] myArray = GetRandomArray();

Console.WriteLine(String.Join("  ", myArray));


int even = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
    even = even +1;
    }
}
   
Console.WriteLine (even);


