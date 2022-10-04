//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine("Введите количество столбцов для двумерного массива: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк для двумерного массива: ");
int line = int.Parse(Console.ReadLine());


double[,] GetArray(int size1, int size2)
{
    double[,] doubleArray = new double[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            doubleArray[i, j] = new Random().NextDouble() * 10 - 4;
        }
    }
    return doubleArray;
}

double[,] array = GetArray(line, column);

void PrintArray()
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"|{Math.Round(array[i, j], 2)}|");
        }
        Console.WriteLine();
    }
}
PrintArray();