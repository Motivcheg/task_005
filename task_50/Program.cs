// Я написал 2 варианта, так как не совсем понял условия задачи. Варианты отделены "//////".


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


///////////////////////////////////////////////////////////////////////////////////////////////////////////

// Console.WriteLine("Введите нужное количество столбцов массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите нужное количество линий массива: ");
// int line = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("_________________________________________");


// int[,] GetArray(int size1, int size2)
// {
//     int count = 1;
//     int[,] array2d = new int[size1, size2];
//     for (int i = 0; i < size1; i++)
//     {
//         for (int j = 0; j < size2; j++)
//         {
//             Console.WriteLine($"Введите {count}-й элемент массива: ");
//             int newElement = Convert.ToInt32(Console.ReadLine());
//             array2d[i, j] = newElement;
//             count++;
//         }
//     }
//     return array2d;
// }
// int[,] array = GetArray(line, column);

// void PrintArray()
// {
//     Console.WriteLine("____________________");
//     Console.WriteLine("Ваш двумерный массив: ");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"|{array[i, j]}|");
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray();

// void FindElem()
// {
    
//     Console.WriteLine("Введите какой элемент нужно найти: ");
//     int findElement = Convert.ToInt32(Console.ReadLine());
//     int box = 999999999; //кастыль, долго мучался, но к сожалению прибег к такому варианту, ибо в массиве могут быть 0, но и не исключается, что может быть и это число :D
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == findElement) box = findElement;            
//         }
//     }


//     if (findElement == box)
//     {
//         Console.WriteLine($"Элемент |{findElement}| есть в массиве.");
//     }
//     else Console.WriteLine($"Элемент |{findElement}| нет в массиве.");
    
// }
// FindElem();


///////////////////////////////////////////////////////////////////////////////////////////////////////////

// Console.WriteLine("введите номер строки");
// int line = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int column = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [4,4];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// if (line > numbers.GetLength(0) || column > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {line} строки и {column} столбца равно |{numbers[line-1,column-1]}|");
// }



// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"|{array[i,j]}|");
//         } 
//         Console.WriteLine(""); 
//     }
// }

