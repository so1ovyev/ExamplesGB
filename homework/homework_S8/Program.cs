using System.Runtime.InteropServices;
Task54();
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

void Task54()
{
    Console.WriteLine("Array sorting");
    int[,] array = RandomArray(ReadInt("firstlength"), ReadInt("secondlength"), ReadInt("minvalue"), ReadInt("maxvalue"));
    PrintArray(array);
    SortEveryRow(array);
    PrintArray(array);
    NextTask();
}

Task56();
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Task56()
{
    Console.WriteLine("Raw smallest sum elements");
    int[,] array = RandomArray(ReadInt("firstlength"), ReadInt("secondlength"), ReadInt("minvalue"), ReadInt("maxvalue"));
    PrintArray(array);
    Row (array);
    NextTask();
}

Task58(); 
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void Task58()
{
    Console.WriteLine("Matrix product");
    int[,] firstMatrix = RandomArrayFixedValue(ReadInt("First matrix rows"), ReadInt("First matrix colums"));
    int[,] secondMatrix = RandomArrayFixedValue(ReadInt("Second matrix rows"), ReadInt("Second matrix colums"));
    PrintArray(firstMatrix);
    PrintArray(secondMatrix);
    MatrixProduct(firstMatrix, secondMatrix);
    NextTask();
}

Task60();
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

void Task60()
{
    Console.WriteLine("Array output with indexes");
    int[,,] array = RandomThreeDimensionalArray(ReadInt("firstlength"), ReadInt("secondlength"), ReadInt("thirdlength"));
    PrintDimensionalArray(array);
    NextTask();
}

Task62(args);
//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void Task62(string[] args)
{
    Console.WriteLine("Spiral array");
    while (true)
    {
        Console.Write("Enter a non-negative number (0 - exit): ");

        int n;
        if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break;

        Console.WriteLine();

        int[,] array = new int[n, n];

        int i = 0, j = 0;

        int value = 1;

        while (n != 0)
        {
            int k = 0;
            do { array[i, j++] = value++; } while (++k < n - 1);
            for (k = 0; k < n - 1; k++) array[i++, j] = value++;
            for (k = 0; k < n - 1; k++) array[i, j--] = value++;
            for (k = 0; k < n - 1; k++) array[i--, j] = value++;

            ++i; ++j; n = n < 2 ? 0 : n - 2;
        }

        PrintSpiralArray(array);
        Console.WriteLine();
    }
}

void MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] matrixProduct = new int[secondMatrix.GetLength(0), secondMatrix.GetLength(1)];

    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    matrixProduct[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
        PrintArray(matrixProduct);
    }
    else
    {
        Console.WriteLine("Multiplication is not possible!");
        Console.WriteLine("The number of columns of the first matrix is not equal to the number of rows of the second matrix.");
    }

}

int SumRow(int[,] array, int row)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {    
        sum += array[row, i];        
    }
    return sum;
}

void Row(int[,] array)
{
    int minsum = SumRow(array, 0);
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (minsum > SumRow(array, i))
        {
            minsum = SumRow(array, i);
            count = i;
        }
    }
    Console.WriteLine($"minimal sum, row: {count + 1}");

}

void SortEveryRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRow(array, i);
    }
}

void SortRow(int[,] array, int row)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[row, i] > array[row, j])
            {
                int temp = array[row, i];
                array[row, i] = array[row, j];
                array[row, j] = temp;
            }
        }
    }
}

int ReadInt (string arg)
{
    Console.Write($"Input {arg}: ");
    return int.Parse(Console.ReadLine());
}

int[,] RandomArray (int firstlength, int secondlength, int minvalue, int maxvalue)
{
    int[,] array = new int[firstlength, secondlength];
    Random random = new Random();

    for (int i = 0; i < firstlength; i++)
    {
        for (int j = 0; j < secondlength; j++)
        {
            array[i, j] = random.Next(minvalue, maxvalue + 1);
        }
    }
    return array;
}

int[,] RandomArrayFixedValue(int firstlength, int secondlength)
{
    int[,] array = new int[firstlength, secondlength];
    Random random = new Random();

    for (int i = 0; i < firstlength; i++)
    {
        for (int j = 0; j < secondlength; j++)
        {
            array[i, j] = random.Next(1, 16);
        }
    }
    return array;
}

int[,,] RandomThreeDimensionalArray (int firstlength, int secondlength, int thirdlength)
{
    int[,,] array = new int[firstlength, secondlength, thirdlength];
    Random random = new Random();

    for (int i = 0; i < firstlength; i++)
    {
        for (int j = 0; j < secondlength; j++)
        {
            for (int k = 0; k < thirdlength; k++)
            {
                int value = random.Next(100, 1000);
                if (!HasValueInThreeDimensionalArray(array, value))
                    array[i, j, k] = value;
                else
                {
                    k--;
                }
            }
        }
    }
    return array;

}

bool HasValueInThreeDimensionalArray(int[,,] array, int value)
{
    foreach (int item in array)
    {
        if (item == value)
        {
            return true;
        }
    }

    return false;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintDimensionalArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"| {array[i, j, k]} ({i}, {j}, {k}) | ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void NextTask()
{
    Console.Write("Next task 'Enter'");
    Console.ReadLine();
    Console.WriteLine();
}

void PrintSpiralArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0,3} ", a[i, j]);
        }
        Console.WriteLine();
    }
}

    


