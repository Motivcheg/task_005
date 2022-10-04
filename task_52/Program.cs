// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine("Введите нужное количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нужное количество линий массива: ");
int line = Convert.ToInt32(Console.ReadLine());

int[,] array = GetRandArr(line, column);

PrintArray();



int[,] GetRandArr(int size1, int size2)
{
    int[,] array2d = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array2d[i, j] = new Random().Next(-10, 10);
        }
    }
    return array2d;
}



void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"|{array[i, j]}|");
        }
        Console.WriteLine("");
    }
}

void ArithmeticMeanColumnArr()
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        double average = sum / array.GetLength(0);
        Console.Write($"{average:F1} ");
    }

}
ArithmeticMeanColumnArr();
