//Task53();
Task55();

void Task53()
{
	int[,] array = GetTwoDimensionArray(ReadInt("First Length"), ReadInt("Secomd Length"));

	PrintArray(array);
	ChangeFirstAndLastRows(array);
	PrintArray(array);
}

#region CommonMethods
int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}

	Console.WriteLine();
}

int[,] GetTwoDimensionArray(int firstLength, int secondLength)
{
	int[,] array = new int[firstLength, secondLength];
	Random rnd = new Random();

	for (int i = 0; i < firstLength; i++)
	{
		for (int j = 0; j < secondLength; j++)
		{
			array[i, j] = rnd.Next(100);
		}
	}

	return array;
}

#endregion

#region Task53 
void ChangeFirstAndLastRows(int[,] array)
{
	int[] firstRow = GetFirstRow(array);
	PutLastRowOnFirstRow(array);
	PutFirstRowOnLastRow(array, firstRow);
}


int[] GetFirstRow(int[,] array)
{
	int[] tempArray = new int[array.GetLength(0)];

	for (int i = 0; i < array.GetLength(1); i++)
	{
		tempArray[i] = array[0, i];
	}

	return tempArray;
}

void PutLastRowOnFirstRow(int[,] array)
{
	int lastRowIndex = array.GetLength(0) - 1;

	for (int i = 0; i < array.GetLength(1); i++)
	{
		array[0, i] = array[lastRowIndex, i];
	}
}

void PutFirstRowOnLastRow(int[,] array, int[] firstRow)
{
	int lastRowIndex = array.GetLength(0) - 1;

	for (int i = 0; i < array.GetLength(1); i++)
	{
		array[lastRowIndex, i] = firstRow[i];
	}
}
#endregion


#region Task55

void Task55()
{
	int[,] array = GetTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
	PrintArray(array);

	if (!IsPossibleToChangeRowToColumns(array))
	{
		Console.WriteLine("Incorrect array");
		return;
	}

	int[,] copy = Copy(array);

	for (int i = 0; i < array.GetLength(0); i++)
	{
		ChangeRowOnColumn(array, copy, i);
	}

	PrintArray(array);
}

bool IsPossibleToChangeRowToColumns(int[,] array)
{
	return array.GetLength(0) < array.GetLength(1);
}

int[] GetRow(int[,] array, int rowNumber)
{
	int[] tempArray = new int[array.GetLength(0)];

	for (int i = 0; i < array.GetLength(0); i++)
	{
		tempArray[i] = array[rowNumber, i];
	}

	return tempArray;
}

void ChangeRowOnColumn(int[,] array, int[,] copy, int row)
{
	int[] changebaleRow = GetRow(copy, row);

	for (int i = 0; i < array.GetLength(1); i++)
	{
		if (i < changebaleRow.Length)
		{
			array[i, row] = changebaleRow[i];
		}
		else
		{

			array[row, array.GetLength(1) - (array.GetLength(1) - i)] = 0;
		}
	}

}

int[,] Copy(int[,] array)
{
	int[,] copy = new int[array.GetLength(0), array.GetLength(1)];

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			copy[i, j] = array[i, j];
		}
	}

	return copy;
}
#endregion