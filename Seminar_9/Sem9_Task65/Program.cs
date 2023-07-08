// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Enter 2 numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

void ShowNumbers(int n2, int n1)
{
    if (n2 <= n1 - 1) return;
    ShowNumbers(n2 - 1 , n1);
    Console.Write(n2 + ", ");
}

ShowNumbers(number2, number1);