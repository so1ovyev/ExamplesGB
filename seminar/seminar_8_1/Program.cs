#region
//region - Позволяет сворачивать строки
//Shift + alt - выделить несколько строк
//&& - И
//|| - ИЛИ
#endregion

int ReadInt(string arg)
{
    Console.Write($"Input {arg}: ");
    return int.Parse(Console.ReadLine());
}

int[,] RandomArray(int firstlength, int secondlength, int minvalue, int maxvalue)
{
    int[,] array = new int[firstlength, secondlength];
    Random random = new Random();

    for (int i = 0; i < firstlength; i++)
    {
        for (int j = 0; j < secondlength; j++)
        {
            array[i, j] = random.Next(minvalue, maxvalue);
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


//Task53();
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку

void Task53()
{
    int[,] array = RandomArray(ReadInt("firstlength"), ReadInt("secondlength"), ReadInt("minvalue"), ReadInt("maxvalue"));
    PrintArray(array);
    Console.WriteLine();
    ReplacementFirstSecond(array);
    PrintArray(array);
}

#region Task53
//Напишите программу, которая поменяет местами первую и последнюю строку
void ReplacementFirstSecond(int[,] array)
{
    int[] newarray = ArrayString(array);
    PutLastOnFirst(array);
    PutFirstOnLast(array, newarray);
}
//Создание одномерного массива для передачи в него первой строки
int[] ArrayString(int[,] array)
{
    int[] newarray = new int [array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    //i < array.GetLength(1) идем по строкам
    {
        newarray[i] = array[0, i];
        //Помещаем в одномерный массив строку из двумерного массива
    }
    return newarray;
}

//Замена последней строки на первую
void PutLastOnFirst(int[,] array)
{
    int LastRowIndex = array.GetLength(0) - 1;
    //Последний индекс

    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0,i] = array[LastRowIndex,i];
        //На место перемещенной в одномерный массив строки помещаем последнюю строку
    }
}

//Замена первой строки на послденюю
void PutFirstOnLast(int[,] array, int[] newarray)
{
    int LastRowIndex = array.GetLength(0) - 1;
    //Последний индекс

    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[LastRowIndex, i] = newarray[i];
        //На место последней строки помещаем сохраненную в одномерном массиве первую строку
    }
}
#endregion


//Task55();
//Задайте двумерный массив. Напишите программу которая заменяет строки на столбцы.
//В случае если это невозможно программа должна вывести сообщение для пользователя.

//Напишите программу которая заменяет строки на столбцы.
//В случае если это невозможно программа должна вывести сообщение для пользователя.

//Когда невозможно заменить строки на столбцы?
//Когда строка длиней столбца.
//Условие. Строка должна быть короче столбца.

void Task55()
{
    int[,] array = RandomArray(ReadInt("firstlength"), ReadInt("secondlength"), ReadInt("minvalue"), ReadInt("maxvalue"));
    PrintArray(array);

    if (!IsPossibleToChengeRowToColumns(array))
    {
        Console.Write("Incorrect array");
        return;
    }

    int[,] copy = Copy(array);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        ChangeRowOnColumn(array, copy, i);
    }
    PrintArray(array);
}

#region Task 55
bool IsPossibleToChengeRowToColumns(int[,] array)
{
    return array.GetLength(0) <= array.GetLength(1);
}

int[] GetRow (int[,] array, int rowNumber)
{
    int[] newarray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    //i < array.GetLength(1) идем по строкам
    {
        newarray[i] = array[rowNumber, i];
        //Помещаем в одномерный массив строку из двумерного массива
    }
    return newarray;
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

void ChangeRowOnColumn(int[,] array, int [,] copy, int row)
{
    int[] ChengebaleRow = GetRow(copy, row);

    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (i < ChengebaleRow.Length)
        {
            array[i, row] = ChengebaleRow[i];
        }
        else
        {
            array[row, (array.GetLength(1) - (array.GetLength(1) - i))] = 0;
        }            
    }
}

//void ChangeRowOnColumn(int[,] array, int[,] copy, int row)
//{
//    int[] changebaleRow = GetRow(copy, row);
//
//    for (int i = 0; i < array.GetLength(1); i++)
//    {
//        if (i < changebaleRow.Length)
//        {
//            array[i, row] = changebaleRow[i];
//        }
//        else
//        {
//
//            array[row, array.GetLength(1) - (array.GetLength(1) - i)] = 0;
//        }
//    }
//
//}
#endregion