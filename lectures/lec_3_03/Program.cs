//1. Найти позицию минимального элемента
//2. Произвести обмен этого элемента со значением первой неотсортированной позиции
//3. Повторять пока есть неотсортированные элементы

using System.Runtime.Serialization.Formatters;

int[] array = { 1, 2, 3, 4, 1, 6, 2, 8, 5 };

void PrintArray(int[] array)
{
    //int count = array.Length;
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} / ");
	}
	Console.WriteLine();
}

void SelectionSortMin(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int minPosition = i;
		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] < array[minPosition]) minPosition = j;
		}
		int temporary = array[i];
		array[i] = array[minPosition];
		array[minPosition] = temporary;
	}
}

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(array);
SelectionSortMax(array);
PrintArray(array);

