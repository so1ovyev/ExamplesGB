//Показ количества заданных чисел 10-99

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, -100, 300);

PrintArray(array);
Console.WriteLine();
search1(array);

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

void search1(int[] array)
{
  int count=0;
  for (int i=0; i < array.Length; i++)
  {
    if (array[i]>=10 && array[i]<=99)
    {
        count++;
    }
  }
  System.Console.WriteLine(count);
}