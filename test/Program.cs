// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Linq;
Clear();
// Создайте двухмерный массив размером m x n в котором каждый элемент находится по формуле A=m+n
// Write("Введите количество строк массива - ");
// int a = int.Parse(ReadLine());
// Write("Введите количество столбцов массива - ");
// int b = int.Parse(ReadLine());
// int [,]matr=GetMatrixArray(a,b);
// PrintMatrixArray(matr);


// int [,] GetMatrixArray (int rows, int columns)
// {
//     int [,] resuit = new int [rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             resuit[i,j] = i + j;
//         }
//     }
//     return resuit;
// }

// void PrintMatrixArray(int [,] inArray)
// {
//     for (int i = 0; i<inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray [i,j]} ");
//         }
//         WriteLine();
//     }
// }
// задать массив случайных чисел, найти элемент у которых оба элемента чётные и заменить их на квадраты

Write("Введите количество строк в матрице: ");
int a = int.Parse(ReadLine());
Write("Введите количество столбцов в матрице: ");
int b = int.Parse(ReadLine());
Write("Введите минимальное значение которое может принимать матрица: ");
int c = int.Parse(ReadLine());
Write("Введите максимальное значение которое может принимать матрица: ");
int d = int.Parse(ReadLine());
int[,]array1= GetTabl (a, b, c, d);
PrintMatrixArray(array1);
WriteLine();
int [,]array2= EvenIndexOnSquare(array1);
PrintMatrixArray(array2);

// Метод заполнения двухмерного массива случайными числами
int [,] GetTabl (int rows, int columns, int minVaiue, int maxValue)
{
    int [,] resuit = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resuit[i,j] = new Random().Next(minVaiue, maxValue+1);
        }
    }
    return resuit;
}
// Метод печати двухмерного массива
void PrintMatrixArray(int [,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray [i,j]} ");
        }
        WriteLine();
    }
}
// Замена элементов с двуья чётными индексами на квадраты найденных элементов
int [,] EvenIndexOnSquare(int [,] matr)
{
    int[,] array = matr;
    for (int i = 0; i<matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                array[i,j]=matr[i,j]*matr[i,j];
            }
            array[i,j]=matr[i,j];
        }    
    }
    return array;
}