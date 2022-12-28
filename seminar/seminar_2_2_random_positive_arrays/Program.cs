// 36. Задать массив, заполнить случайными положительными
//     трёхзначными числами. Показать количество нечетных\четных чисел


// 0. Получение числа, которое можно использовать для создания массива

// 1. Метод создания массива с указанным размером
// int[] CreateArray(int count)
int[] CreateArray(int count)
{
    return new int[count];
}
// 2. Метод заполения
//  void Fill(int[] array, int min, int max)
void Fill(int[] array, int min, int max)
{
    int count = 0;
    int length = array.Length;
    while (count < length)
    {
        int element = new Random().Next(min, max + 1);
        array[count] = element;
        count++;
    }

}
// 3. Вывод результата
//   string Print(int[,] pair) 
void Print1(int[] pair)
{
    Console.WriteLine("Количество четных чисел в массиве " + pair[0]);
    Console.WriteLine("Количество нечетных чисел в массиве " + pair[1]);
}

// 4. Метод подсчёта четных\нечетных
int[] JoinJob(int[] data)
{
    int[] result = { 0, 0 };
    int size = data.Length;
    int index = 0;
    while (index < size)
    {
        if (data[index] % 2 == 0) result[0]++;
        if (data[index] % 2 != 0) result[1]++;
        index++;
    }
    return result;
}

int[] inputData = CreateArray(100);
Fill(inputData, 0, 10);
int[] result = JoinJob(inputData);
Print1(result);

System.Console.WriteLine();