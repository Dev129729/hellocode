// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> нет

int [] GetRandomArray()
{
int[] array = new int[5];
for (int i = 0; i<array.Length; i++)
{
    array[i] = Random.Shared.Next(-345, 345);
}
return array;
}
int[] myArray = GetRandomArray();
int count = 0;
Console.WriteLine(String.Join("  ", myArray));
Console.WriteLine("Enter the number");
int numberFind = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < myArray.Length; i++)
    {
        if (numberFind ==  myArray [i])
        {
        count++;
        break;
        }
       
    }
if(count == 1) 
{        
    Console.WriteLine("Yes");
}   
else
{
        Console.WriteLine("No");
}


