// Задача 47. Задайте двумерный массив размером
//  m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//указываем данные для двухмерного массива
Console.Write("Введите количество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int colomns = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[rows,colomns];

// Метод заполняет массив
void FillingArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]= Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
        }
    }
}
// Метод выводит массив
void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
        
    }
}

FillingArray();
PrintArray();
