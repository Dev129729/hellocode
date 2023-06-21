// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt()
{
    Console.WriteLine ("Enter int number");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int sumofdigits(int a)
{
    int count = 0;
    while (a > 0)
    {
        count = count + a%10;
        a = a / 10;
    } 

    return count;
}

int number = ReadInt();
int summa = sumofdigits(number);
Console.WriteLine(summa);
 