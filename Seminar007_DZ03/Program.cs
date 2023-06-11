// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца
// : 4,6; 5,6; 3,6; 3.

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
            matrix[i, j] = new Random().Next(1, 10);
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
        Console.WriteLine("");

    }
}
// Поиск среднеарифмитического значения элемента 
void SredneeColomn()
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double SredneeColomn = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            SredneeColomn += matrix[i,j];
        }
        Console.Write($"[{SredneeColomn /= matrix.GetLength(0)}] ");
    }
    Console.WriteLine("");
}
// Выводы
FillingArray();
Console.WriteLine("");
Console.WriteLine("----------Среднее-----------");
SredneeColomn();
Console.WriteLine("");
Console.WriteLine("-----------Массив-----------");
PrintArray();
