// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

Console.WriteLine("размер массива ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("число ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool isFind = false;

int [] array = new int[num];

for(int i = 0; i<array.Length; i++)
{
    array[i]= new Random().Next(0,20); //Случайные числа
    Console.Write(array[i]+  " ");

    if(array[i]== num2)
    {
        isFind = true;
    }
}

if(isFind = true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("No");
}