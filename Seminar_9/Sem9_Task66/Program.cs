// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter 2 numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int Summ(int n, int m)
{
    if (n == m) return n;
    else return Summ(n + 1, m) + n;
}

Console.WriteLine(Summ(number1, number2));