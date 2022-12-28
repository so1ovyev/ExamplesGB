using System.Text;

Task38();

void Task34()
{
	int length = ReadInt("Array length");

	int[] array = CreateArray(length, 100, 1000);

	Console.WriteLine(GetArrayAsString(array));
	Console.WriteLine(GetEvenCount(array));
}

void Task36()
{
	int length = ReadInt("Array length");

	int[] array = CreateArray(length, 1, 10);

	Console.WriteLine(GetArrayAsString(array));
	Console.WriteLine($"Sum is {GetSumOnNotEvenPositions(array)}");
}

void Task38()
{
	int length = ReadInt("Array length");

	double[] array = CreateDoubleArray(length);

	Console.WriteLine(GetDoubleArrayAsString(array));
	Console.WriteLine($"Sum is {GetSumBetweenMaxAndMin(array)}");
}

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length, int minValue, int maxValue)
{
	Random random = new Random();
	int[] array = new int[length];

	for (int i = 0; i < length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}

double[] CreateDoubleArray(int length)
{
	Random random = new Random();
	double[] array = new double[length];

	for (int i = 0; i < length; i++)
	{
		array[i] = Math.Round(random.NextDouble() * 10, 2);
	}

	return array;
}

int GetEvenCount(int[] array)
{
	int count = 0;

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0) count++;
	}

	return count;
}

int GetSumOnNotEvenPositions(int[] array)
{
	int sum = 0;

	for (int i = 0; i < array.Length; i++)
	{
		if ((i + 1) % 2 != 0) sum += array[i];
	}

	return sum;
}

string GetArrayAsString(int[] array)
{
	StringBuilder sb = new StringBuilder(array.Length);

	for (int i = 0; i < array.Length; i++)
	{
		sb.Append($"{array[i]}, ");
	}

	return sb.ToString();
}

string GetDoubleArrayAsString(double[] array)
{
	StringBuilder sb = new StringBuilder(array.Length);

	for (int i = 0; i < array.Length; i++)
	{
		sb.Append($"{array[i]}, ");
	}

	return sb.ToString();
}

double GetSumBetweenMaxAndMin(double[] array)
{
	double max = array[0];
	double min = array[0];

	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] > max) max = array[i];
		else if (array[i] < min) min = array[i];
	}

	return max - min;
}