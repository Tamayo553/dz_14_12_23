// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

// int [,] array = new int[5,3];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] +" ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void ChangeArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i%2==0 && j%2==0)
//             {
//                 array[i,j] = array[i,j] * array[i,j];
//             }
//         }
//         System.Console.WriteLine();
//     }
// }

// CreateArray();
// PrintArray();
// ChangeArray();
// PrintArray();






// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

// int [,] array = new int[6,5];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] +" ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElArray()
// {
//     int sumEl=0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i==j)
//             {
//                 sumEl= sumEl+ array[i,j];
//             }
//         }
//     }
//     System.Console.WriteLine("Сумма = "+ sumEl);
// }

// CreateArray();
// PrintArray();
// FindElArray();











// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

// int [,] array = new int[6,5];
// double [] array2 = new double[array.GetLength(0)];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] +" ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumEl=0;

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumEl+= array[i,j];
//         }
//         array2[i]=(double) sumEl/array.GetLength(1);
//     }
// }
// void PrintArray2()
// {
//     for (int i = 0; i < array2.Length; i++)
//     {
//       System.Console.Write(array2[i] +" ");    
//     }
// }

// CreateArray();
// PrintArray();
// FindElArray();
// PrintArray2();








