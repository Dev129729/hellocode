// 5. Напишите программу, кооторая на вход принимает одно число (n), а на выходе показывает все целые числа в промежутке от -N до N. 

Console.WriteLine("Enter N");
string n = Console.ReadLine();
int b = Convert.ToInt32(n);
for (int i = -b; i<=b; i++)
{
    Console.WriteLine(i);
}
