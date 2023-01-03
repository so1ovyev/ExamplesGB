Task34();
//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//Напишите программу, которая покажет количество чётных чисел в массиве.
void Task34()
{
    Console.WriteLine("Amount even numbers in array");
    Console.WriteLine();
    
    int[] array = RandomArray(Readint("Lenght"), 100, 999);
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"In array {count} even numbers");
   
    Console.Write("Next task 'Enter'");
    Console.ReadLine();
}

Task36();
//Задайте одномерный массив, заполненный случайными числами. +++
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Найдите сумму элементов, стоящих на нечётных позициях.
void Task36()
{
    Console.WriteLine("Search element in odd positions");
    Console.WriteLine();
    
    int[] array = RandomArray(Readint("leng"), Readint("minValue"), Readint("maxValue"));
    int count = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        count += array[i];
    }
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Sum elements on odd = {count}");
   
    Console.Write("Next task 'Enter'");
    Console.ReadLine();
}

Task38();
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//Найдите разницу между максимальным и минимальным элементов массива.
void Task38()
{
    Console.WriteLine("difference maximum minimal positions");
    Console.WriteLine();

    double[] array = ArrayRandom(Readint("Lenght"), Readint("minValue"), Readint("maxValue"));
    PrintDoubleArray(array);
    Console.WriteLine();
    double min = SearchMin(array);
    double max = SearchMax(array);
    double difference = max - min;
    Console.WriteLine($"Difference between maximum ({Math.Round(max, 2)}) and minimum ({Math.Round(min, 2)}) = {Math.Round(difference, 2)} ");
    
    Console.Write("Exit 'Enter'");
    Console.ReadLine();
}


int Readint (string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int[] RandomArray(int length,int  minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Задайте массив вещественных чисел.
double[] ArrayRandom(int lenght, int minValue, int maxValue)
{
    double[] array = new double[lenght];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1) + random.NextDouble();
    }
    return array;
}

void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)}; ");
    }
}

double SearchMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double SearchMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}









