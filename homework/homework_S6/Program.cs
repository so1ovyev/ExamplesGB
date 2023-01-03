Task41();
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void Task41()
{
    Console.WriteLine("More numbers zero");
    Console.WriteLine();

    int[] array = Array(ReadInt("amount of numbers"));
    PrintArray(array);
    Console.WriteLine();
    PositiveNumbers(array);

    Console.Write("Next task 'Enter'");
    Console.ReadLine();
}

Task43();
//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2;
//k1 = 5;
//b2 = 4;
//k2 = 9;
//(-0, 5; -0,5)

//Приравниваем правые части данных равенств:
//k1 * x + b1 = k2 * x + b2
//Отсюда x:
//x = (b2 - b1) / (k1 - k2)
//затем подставим х в выражение для у:
//y = k1(b2 - b1) / (k1 - k2) + b1

void Task43()
{
    Console.WriteLine("Search point intersection two lines");
    Console.WriteLine();    

    double b1 = ReadDouble("B1");
    double k1 = ReadDouble("K1");
    double b2 = ReadDouble("B2");
    double k2 = ReadDouble("K2");
    double x = SearchX(b1, b2, k1, k2);
    double y = SearchY(b1, b2, k1, k2);
    Console.WriteLine($"{Math.Round(x, 2)}; {Math.Round(y, 2)}");

    Console.Write("Exit 'Enter'");
    Console.ReadLine();
}

int ReadInt (string arg)
{
    Console.Write($"Input {arg}: ");
    return int.Parse(Console.ReadLine());
}

int[] Array (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"number {i+1}");
    }
    return array;
}

void PrintArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}; ");
    }
}

void PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"{count} positiv numbers");
}

double ReadDouble(string arg)
{
    Console.Write($"Input {arg}: ");
    return double.Parse(Console.ReadLine());
}

double SearchX (double b1, double b2, double k1, double k2)
{
    double x = 0;
    x = (b2 - b1) / (k1 - k2);
    return x;
}

double SearchY (double b1, double b2, double k1, double k2)
{
    double y = 0;
    y = (b2 - b1) * k1 / (k1 - k2) + b1;
    return y;
}