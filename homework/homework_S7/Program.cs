Task47();
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void Task47()
{
    Console.WriteLine("Two-dimensional array, filled with random real numbers");
    Console.WriteLine();
    double[,] array = RandoDoubleArray(ReadInt("firstlength"), ReadInt("secondlength"), ReadInt("minvalue"), ReadInt("maxvalue"));
    PrintDoubleArray(array);
    Console.Write("Next task 'Enter'");
    Console.ReadLine();    
}


Task50();
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет

void Task50()
{
    Console.WriteLine("Search element positions array");
    Console.WriteLine();
    int[,] array = RandomFixedLengthArray();
    PrintArray(array);
    Console.WriteLine();
    SearchElement(array, ReadInt("X"), ReadInt("Y"));
    Console.Write("Next task 'Enter'");
    Console.ReadLine();
}

Task52();
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Task52()
{
    Console.WriteLine("Average column");
    Console.WriteLine();
    int[,] array =  RandomArray(ReadInt("firstlength"), ReadInt("secondlength"), ReadInt("minvalue"), ReadInt("maxvalue"));
    PrintArray(array);
    Console.WriteLine();
    Average(array);
    Console.Write("Exit 'Enter'");
    Console.ReadLine();
}


int ReadInt (string arg)
{
    Console.Write($"Input {arg}: ");
    return int.Parse(Console.ReadLine());
}

double[,] RandoDoubleArray (int firstlength, int secondlength, int minvalue, int maxvalue)
{
    double[,] array = new double[firstlength, secondlength];
    Random random= new Random();

    for (int i = 0; i < firstlength; i++)
    {
        for (int j = 0; j < secondlength; j++)
        {
            array[i,j] = random.Next(minvalue, maxvalue+1) + random.NextDouble();
        }
    }
    return array;
}

void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)}; ");
        }
        Console.WriteLine();
    }
}

int[,] RandomFixedLengthArray()
{
    int[,] array= new int[5, 10];
    Random random= new Random();

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            array[i, j] = random.Next(1, 1001 );
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; ");
        }
        Console.WriteLine();    
    }
}

void SearchElement(int[,] array, int x, int y)
{
    int searchelement = 0;

    if (x > 0 && y > 0 && x < array.GetLength(0)+1 && y < array.GetLength(1)+1)
    //GetLength(0)+1 && GetLength(1)+1 т.к. массив меньше числа
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == x-1 && j == y-1) searchelement = array[(i), (j)];
                //x-1 && y-1 - смещение
            }
        }
    Console.WriteLine($"{searchelement}");
    }
    else Console.WriteLine("No elements");
}

int[,] RandomArray(int firstlength, int secondlength, int minvalue, int maxvalue)
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

void Average (int[,] array)
{
    double variable = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            variable += array[i,j];
        }
        Console.WriteLine($"Average {j+1} column = {Math.Round(variable / array.GetLength(0), 2)}");
        variable = 0;
    }
}





