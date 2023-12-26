//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

class Program 
{
    static void Main() {
        
        int[] array = {34 , 15 , 74, 85, 0,7};

        
        PrintArray(array, array.Length - 1);
    }
    static void PrintArray(int[] array, int index) 
    {
        if (index < 0) 
        {
            return;
        }

        Console.Write(" ");
        Console.Write(array [ index ]);

        
        PrintArray(array, index - 1);
    }
}

