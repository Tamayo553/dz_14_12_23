// //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] array = new int[3,3];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(1,10);
//         System.Console.Write("{0}", array[i,j] + " ");
//     }
//     System.Console.WriteLine();
// }

// int sum = 0;
// for (int j = 0; j < array.GetLength; ++j)
// {
//     for (int i = 0; i < array.GetLength; ++i)
//     {
//         sum = sum + array[i][j];
//     }
//     Console.WriteLine(String.Format("Summation of {0}th column is {1}", j,sum)); 
//     sum=0;       
// }

//int minSum = int.MaxValue;
    // int minSumLine = 0;
    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     int sum1 = array[0,0];
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         sum1+=array[i,j];
    //     }
    //     if (sum1 < minSum)
    //     {
    //         minSum = sum1;
    //         minSumLine = i;
    //     }
    // }

int [,] array = new int[3,3];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] +" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ChangeArray()
{
    int minSum = 0;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+= array[i,j];
        }
        if (i==0)
        {
            minSum=sum;
        }
        else if(sum < minSum)
        {
            minRow = i;
        }
    }
    Console.WriteLine($"Строка с наиеньшей суммой = {minRow}");
}

CreateArray();
PrintArray();
ChangeArray();
