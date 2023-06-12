int Max(int args1, int args2, int args3)
{
    int result = 0;
    if (args1 > result) result = args1;
    if (args2 > result) result = args2;
    if (args3 > result) result = args3;
    return result;
}

int[] array = {1, 256, 3, 4, 15, 6, 7, 8, 9};



int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);