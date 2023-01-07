void Task64 (int N)
{
    if (N <= 1)
    {
        Console.Write(N);
        return;
    }
    Console.Write($"{N}, ");
    Task64(N - 1);
}

Task64(7);