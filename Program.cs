//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double[,] Create2DRandomArray (int minValue, int maxValue, int rows, int columns)
{
    double[,] newArray = new double[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return newArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + " "); 
        }
        Console.WriteLine();
    }   
}

Console.WriteLine("Введите минимальное число массива  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива  ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество строк  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов  ");
int columns = Convert.ToInt32(Console.ReadLine());
PrintArray(Create2DRandomArray(min,max,rows,columns));
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

/*
int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

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

void ElemArray(int[,] array, int n, int m)
{
    if (n > array.GetLength(0) && m > array.GetLength(1))
        Console.WriteLine("такого числа нет в массиве");
    else
    {
        int c = array[n, m];
        Console.WriteLine($"{n} {m} -> {c}");
    }
}

Console.WriteLine("Введите минимальный размер массива  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный размер массива  ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество строк  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество колонн  ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число  ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(min, max, rows, columns);
PrintArray(myArray);
ElemArray(myArray, n, m);
*/



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

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

void SumElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine($"сумма = {sum}");
    }
}


Console.Write("Введите минимальный размер массива  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный размер массива  ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество строк  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество колонн  ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(min, max, rows, columns);
PrintArray(myArray);
SumElement(myArray);