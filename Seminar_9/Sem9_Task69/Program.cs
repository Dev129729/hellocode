// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Enter 2 numbers");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Pow(int n, int m)
{
    if (m == 0 ) return(1);
    return
    Pow(n , m-1)*n;
}

int result =  Pow(a,b);
Console.WriteLine(result);