﻿int [] array = {18, 82, 45, 94, 75, 66, 73, 84, 84};

int n = array.Length;
int find = 84;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;

}

/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int [] array = {11,217,31,41,15,61,17,18,19};
array[0] = 12;
Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);
*/