// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter the number");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(Console.ReadLine());

int[] Array = {a, b, c, d, e, f};
Console.WriteLine(String.Join("  ",Array));
int PositiveNumbers(int[] sourceArray)
{   
    int count = 0;
    for (int i = 0;i < sourceArray.Length; i++)
        {
        if (sourceArray[i]>0)
        {
            count++;
        }
        
}
    return count;
}
Console.WriteLine($"Amount of positive Numbers above 0 is {PositiveNumbers(Array)}");


 