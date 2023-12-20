//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (i > 0 && i < array.GetLength(1))
            {
                int temporary = array[i, j];
                array[i, j] = array[i, j];
                array[i, j] = temporary;
            }
            else
            {
                int temporary = array[i, j];
                array[i, j] = array[(array.GetLength(1) - 1), j];
                array[(array.GetLength(1) - 1), j] = temporary;
            }
        }
    }
}

CreateArray();
PrintArray();
ChangeArray();
PrintArray();





