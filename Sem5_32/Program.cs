// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] GetRandomArray()
{
int[] array = new int[4];
for (int i = 0; i<array.Length; i++)
{
    array[i] = Random.Shared.Next(-8, 8);
}
return array;
}
int[] myArray = GetRandomArray();
Console.WriteLine("Initial array: ");
Console.WriteLine (string.Join("  ", myArray));

    for (int i = 0; i < myArray.Length; i++)
    {
            myArray[i] = -myArray [i];
       
   }

Console.WriteLine("Changed array: ");
Console.WriteLine(String.Join("  ", myArray));


 
 
















// int [] GetRandomArray() 
// {
//     int[] array = new int [4];
//     for(int i = 0;i<array.Length; i++)
//     {
//     array [i] = Random.Shared.Next (-8 , 8);
//     }
// return array;
// };

// int [] GetRandomArray()
// {
// {
    // int[] array = {-4, -8, 8, 2};
// }
// return array;
// }

// int ElementsChange(int[] massive)
// {
//     int ElementsChange = 0;
//     for (int i = 0; i < massive.Length; i++)
//     {
//         if (massive[i] < 0)
//         {
//             ElementsChange = massive [i] + massive [i]*2;
//         }
        // else if (massive[i] > 0)
        // {
        //     massive [i] = massive [i] - massive [i]*2;
        // }
//    }

//    return ElementsChange;
// }
// // int[] myArray = GetRandomArray();
// Console.WriteLine (string.Join(" - ", array));
// int change = ElementsChange(array);
// Console.WriteLine(change);
