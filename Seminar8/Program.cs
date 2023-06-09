﻿// Task 1.
// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива
// или любые две строки

// int[,] CreateRandom2dArray()
// {
//     // это исключение
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();  
// }

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if(row1 >= 0 && row1 < array.GetLength(0) &&
//        row2 >= 0 && row2 < array.GetLength(0) &&
//        row1 != row2)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     else Console.WriteLine("Wrong row numbers!");
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// Console.Write("Input a number of the first row for change: ");
// int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Input a number of the second row for change: ");
// int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

// ChangeRows(myArray, r1, r2);
// Show2dArray(myArray);

// Task 2.
// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы.

// int[,] CreateRandom2dArray()
// {
//     // это исключение
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();  
// }

// void ChangeRowsColumns(int[,] array)
// {    
//     if(array.GetLength(0) == array.GetLength(1))
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//             for(int j = 0; j < i; j++)
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[j, i];
//                     array[j, i] = temp;
//                 }  
//     }      
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// ChangeRowsColumns(myArray);
// Show2dArray(myArray);

// Task 3.
// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.


// int[,] CreateRandom2dArray()
// {
//     // это исключение
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();  
// }

// int[] SearchElement(int[,] array)
// {
//     int[] indexes = {0, 0};
    
//     // int min = array[0, 0];
//     // int rowElement = 0;
//     // int columnsElement = 0;

//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < array[indexes[0], indexes[1]])
//             {
//                 indexes[0] = i;
//                 indexes[1] = j;
//                 // array[i, j] = min;
//                 // rowElement = i;
//                 // columnsElement = j;
//             }
//         }
//     }
//     return indexes;    
// }

// void ShowArray(int[] newArray)
// {
//     for (int i = 0; i < newArray.Length; i++)
//         Console.Write(newArray[i] + " ");
//     Console.WriteLine();
// }

// int[,] DeleteRowsColumns(int[,] array, int[] indexes)
// {
//     int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     for (int i = 0, m= 0; i < array.GetLength(0); i++)
//     {
//         if(i != indexes[0])
//         {
//             for(int j = 0, n = 0; j < array.GetLength(1); j++)
//             {
//                 if(j != indexes[1])
//                     {
//                         newArray[m, n] = array[i, j];
//                         n++;
//                     }
//             }
//             m++;
//         }
//     }
//     return newArray;
    
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// int[] res = SearchElement(myArray);
// ShowArray(res);

// int[,] newResult = DeleteRowsColumns(myArray, res);
// Show2dArray(newResult);