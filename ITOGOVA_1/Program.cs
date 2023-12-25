//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введите M - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N - ");
int n = Convert.ToInt32(Console.ReadLine());

void rek(int m, int n)
{
    if(m>n)
    return;

    if (m > 0 & n>0)
    {
        Console.Write($" {m} ");
    }
    rek(m+1,n);
}
rek(m,n);
