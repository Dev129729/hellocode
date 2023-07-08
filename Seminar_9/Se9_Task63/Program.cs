// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());

void ShowNumbers(int n)
{
    if (n <=0) return;
    ShowNumbers(n-1);
    Console.Write(n);
}

ShowNumbers(number);
