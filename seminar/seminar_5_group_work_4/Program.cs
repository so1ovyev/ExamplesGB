//  Произведение противиположных элементов массива

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, 1, 15);

PrintArray(array);
Console.WriteLine();
Product(array);

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

void Product(int[] array)
{
    for (int i=0; i < (array.Length/2); i++)
    {
        System.Console.Write($"{array[i]*array[length-i-1]}, ");
    }
    if (array.Length%2!=0)
    {
        System.Console.WriteLine(array[array.Length/2]);
    }
}
