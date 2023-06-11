// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Указываем данные для матрицы
Console.Write("Введите количество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int colomns = Convert.ToInt32(Console.ReadLine());
// Построение матрицы
int[,] matrix = new int[rows, colomns];
// Метод заполняет матрицы
void FillingArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
}
// Метод выводит матрицы
void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();

    }
}
// Вводим значения для поиска
Console.Write("Введите индексы для поиска по строке в массиве = ");
int search1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индексы для поиска по столбцу в массиве = ");
int search2 = Convert.ToInt32(Console.ReadLine());
// Поиск элемента
void SearchElementArray(int search1, int search2)
{
    if (search1 < matrix.GetLength(0) && search2 < matrix.GetLength(1))
    {
        Console.WriteLine($"Число в матрице = [ {matrix[search1, search2]} ]");
    }
    else
    {
        Console.WriteLine($" {search1}, {search2} Такой ячейки нет в матрице");
    }
}
// Выводы
FillingArray();
SearchElementArray(search1, search2);
PrintArray();
