﻿// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("Enter the numebr");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
string a = "";
while (number !=0)
{
    i = number%2;
    number = number/2;
    // number /=2;
    a = i + a;
    // a += i;
}

Console.WriteLine(a);