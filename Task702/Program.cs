// Задача № 2. 
// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Проверка:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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
/// Метод вывода на экран двумерного массив
/// </summary>
/// <param name="array"> созданный в программе и заполненный случайными числами двумерный массив </param>
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  "); // Пробел используется для красоты вывода
        }
        System.Console.WriteLine();
    }
}

Console.WriteLine("Программа для нахождения элемента по его месту в двумерном массиве");
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли
System.Console.WriteLine("Перед Вами двумерный массив размером 10 х 10. Значение какого элемента Вас интересует?");

int[,] matrix = new int[10, 10]; // Создание двумерного массива размером 10 на 10
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

Console.Write("Введите значение строки, на которой находится интересующий Вас элемент -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение столбца, на котором находится интересующий Вас элемент -> ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(); // Пустая строка для красоты отобращения в консоли

// Нахождение элемента с заданным адресом в массиве (в теле программы)
if (n > matrix.GetLength(0) || m > matrix.GetLength(1)) // Проверка нахождения элемента в массиве 
{
    Console.Write("Заданный адрес элемента не соответсвует двумерному массиву: такого элемента не существует");
}
else
{
    Console.Write($"Значение элемента строки {n} и столбца {m} равно {matrix[n - 1, m - 1]}.");
    System.Console.WriteLine();
}