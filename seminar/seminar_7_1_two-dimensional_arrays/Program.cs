//Task46();
//Задайте двумерный массив размером m*n, заполненый случайными целыми числами.
//m=3, n=4

using System.Runtime.ExceptionServices;

void Task46()
{
    int[,] array = RandomArray(ReadInt("m"), ReadInt("n"), ReadInt("min"), ReadInt("max"));
    PrintArray(array);
    // Для запуска через F5
    Console.WriteLine("Exit?");
    Console.ReadLine();
}


//Task48();
//Задайте двумерный массив размером m*n, каждый элемент в массиве находится по формуле Аmn = m + n.
//Вывести полученный массив на экран
//m = 3, n = 4.
// 0123
// 1234
// 2345

void Task48()
{
    int[,] array = ArrayMN(ReadInt("M"), ReadInt("N"));
    PrintArray(array);
}

//Task49();
//Задайте двумерный массив. Найдите элементы у которых оба индекса чётные и замените эти элементы на их квадраты

void Task49()
{
    int[,] array = RandomArray(ReadInt("length"), ReadInt("secondlength"), ReadInt("min"), ReadInt("max"));
    PrintArray(array);
    Console.WriteLine();
    SquareArray(array);
    PrintArray(array);
}

//Task51();
//Задать двумерный массивю. Найти сумму эдементов на главной диагонали

void Task51()
{
    int[,] array = RandomArray(ReadInt("length"), ReadInt("secondlength"), ReadInt("min"), ReadInt("max"));
    PrintArray(array);
    Console.WriteLine();
    SumDiagonal(array);
    //SumDiagonalArray(array);
}



//Принт array через строку

//string GetArrayAsString(int[] array)
//{
//    StringBuilder sb = new StringBuilder(array.Length); //Создает новую строку длиной Length
//    // StringBuilder - строитель строк. 
//
//    for (int i = 0; i < array.Length; i++)
//    {
//        sb.Append($"{array[i]}, ");
//    }
//
//    return sb.ToString(); //Возвращает строку
//}

int ReadInt(string arg)
{
    Console.WriteLine($"Input {arg}");
    return int.Parse(Console.ReadLine());
}

int[,] RandomArray(int length, int secondlength, int min, int max)
//[,] Двумерный массив
//(int length, int secondlength). length - длина первого измерения, secondlength - длина второго измерения
{
    int[,] array = new int[length, secondlength];
    Random random = new Random();
   
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondlength; j++)
        {
            array[i, j] = random.Next(min, max);
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

int[,] ArrayMN(int length, int secondlength)
{
    int[,] array = new int[length, secondlength];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondlength; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int[,] SquareArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) array[i, j] *= array[i, j];
            //if (i % 2 != 0 && j % 2 != 0) array[i, j] = Math.Pow(array[i, j], 2);
        }
    }
    return array;
}

void SumDiagonalArray(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum += array[i, j];
        }
    }
    Console.WriteLine($"sum on diagonal = {sum}");
}

void SumDiagonal(int[,] array)
{
    int sum = 0;
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    //if (array.GetLength(0) < array.GetLength(1))
    //length= array.GetLength(0);
    //else length = array.GetLength(1);

    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    Console.WriteLine($"sum on diagonal = {sum}");
}
