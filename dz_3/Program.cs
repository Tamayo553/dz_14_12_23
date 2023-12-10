//Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Введите число - ");
double num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[10];
int count = 0;


for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0.85) / 100;
}
Console.WriteLine(array[i] + " ");

