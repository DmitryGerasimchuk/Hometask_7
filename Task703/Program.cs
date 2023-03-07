// Задача № 3. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Проверка:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/// <summary>
/// Метод заполнения созданного двумерного массива рандомными числами
/// </summary>
/// <param name="array"> созданный в теле программы двумерный массив </param>
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10); // Интервал чисел для рандомного заполнения от 0 до 9
        }
    }
}

/// <summary>
/// Метод вывода на экран двумерного массива
/// </summary>
/// <param name="array"> созданный в программе и заполненный случайными числами двумерный массив</param>
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Программа для нахождения среднего арифметического элементов в каждом столбце");
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

Console.Write("Введите количество строк в двумерном массиве -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество в столбцов в двумерном массиве -> ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

int[,] matrix = new int[n, m]; // Создание двумерного массива
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

// Нахождение среднего арифметического элементов в каждом столбце (сделано в теле программы)
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; "); // ; - чтобы отделить результаты  
}
Console.WriteLine();