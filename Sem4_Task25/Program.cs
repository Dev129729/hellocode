// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt()
{
    Console.WriteLine("Enter the number");
    int value = Convert.ToInt32(Console.ReadLine());
    return (value);
}

int Pow(int A, int B)
{
    int power = 1;
    for (int i = 0; i < B; i++)
    {
        power = power * A;
    }
    return power;
};
int A = ReadInt();
int B = ReadInt ();
Console.WriteLine (Pow(A,B));

