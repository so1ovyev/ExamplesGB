//int length = ReadInt("Array length");
//int find = ReadInt("Find number");
int[] array = GetRandomArray(9, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] newarray = NewArray(array);
PrintArray(newarray);


//int count = FindElements(array);
//Console.WriteLine(count);


//FindNumber(array, find);




//ReversArray(array);
//PrintArray(array);





int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

void ReversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void FindNumber(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            Console.WriteLine("Yes");
            return;
        }
    }
    Console.WriteLine("No");
}

int FindElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= 10) && (array[i] <= 99))
        {
            count++;
        }
    }
    return count;
}

int[] NewArray(int[] array)
{
    int[] newarray = new int[(array.Length / 2) + 1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newarray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)

        newarray[(array.Length / 2)] = array[array.Length / 2];

    return newarray;
}