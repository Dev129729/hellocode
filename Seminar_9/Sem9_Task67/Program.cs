// Задача 67: Напишите программу,
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());

int summ(int n)
{
    if (n <= 0 ) return(0);
    return
    summ(n/10) + (n%10);
 
}

int result =  summ(number);
Console.WriteLine(result);

