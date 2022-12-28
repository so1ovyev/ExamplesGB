//Замена элементов на противоположный знак

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, -9, 9);

PrintArray(array);
plusminus(array);
System.Console.WriteLine();
PrintArray(array);

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


void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

void plusminus(int[] array)
{
    for (int i = 0; i < array.Length; i++)
	{
		array[i] = array[i] * -1;
	}
}
