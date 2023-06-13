// 5. Напишите программу, кооторая на вход принимает одно число (n), а на выходе показывает все целые числа в промежутке от -N до N. 

Console.WriteLine("Enter N");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = -b; i<=b; i++)
{
    Console.WriteLine(i);
}