// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("enter the number");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10000 || N > 99999)
{
    Console.WriteLine("Wrong number");
}
if (N / 10000 == N % 10 && (N / 1000) % 10 == (N / 10)%10)
{Console.WriteLine ("Yes");
    }
    else {Console.WriteLine ("No");
    }