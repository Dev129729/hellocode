// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());

int ShowNumbers(int n, int m)
{
    if (n == m) return n;
    else Console.Write($"{ShowNumbers(n, m + 1)}, ");
    return m;
}

if (number > 0)
{
    Console.WriteLine(ShowNumbers(number, 1));
}
else
{
    Console.WriteLine("Inroccent number");
}