// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник со сторонами такой длины.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a +b > c && b + c > a && c + a > b)
    Console.WriteLine("True");
else
    Console.WriteLine("False");