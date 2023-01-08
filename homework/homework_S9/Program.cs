//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Number from N to 1");
Task64(ReadInt("N"));

//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30
Console.Write("Sum of natural elements from M to N");
Task66(ReadInt("M"), ReadInt("N"));

//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29
Console.WriteLine("Ackerman function");
Console.WriteLine(Task68(ReadInt("M"), ReadInt("N")));

int ReadInt(string arg)
{
    Console.WriteLine();
    Console.Write($"Input {arg}: ");
    return int.Parse(Console.ReadLine());
}

void Task64(int N)
{

    if (N <= 1)
    {
        Console.Write(N);
        Console.WriteLine();
        return;
    }
    Console.Write($"{N}, ");
    Task64(N - 1);
}

void Task66(int M, int N)
{
    int sum = 0;
    while (M <= N) 
    {
        sum += M;
        M++;
    }
    Console.WriteLine(sum);
}

int Task68(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Task68(m - 1, 1);
    }
    return Task68(m - 1, Task68(m, n - 1));
}