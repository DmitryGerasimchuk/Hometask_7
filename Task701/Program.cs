// Задача № 1.
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// Проверка:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/// <summary>
/// Метод заполнения созданного двумерного массива рандомными числами
/// </summary>
/// <param name="array"> созданный в теле программы двумерный массив </param>
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; // Интервал чисел для рандомного заполнения от -10 до 10
        }
    }
}

/// <summary>
/// Метод вывода на экран двумерного массив
/// </summary>
/// <param name="array"> созданный в программе и заполненный случайными числами двумерный массив </param>
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

Console.WriteLine("Программа для запонения двумерного массива случайными вещественными числами");
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

Console.Write("Введите количество строк в двумерном массиве -> ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество в столбцов в двумерном массиве -> ");
int col = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[row, col];
FillArrayRandomNumbers(matrix);
PrintArray(matrix);