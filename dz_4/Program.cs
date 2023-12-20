//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[2,3];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
        System.Console.Write("{0}", array[i,j]);
    }
    System.Console.WriteLine();
}
if (pos1 < 0 | pos1 > array.GetLength(0) | pos2 < 0 | pos2> array.GetLength(1))
{
    Console.WriteLine("Элемент не найден ");
}
else
{
    Console.WriteLine("Элемент массива = {0} ", array[pos1,pos2]);
}
Console.ReadLine();


q