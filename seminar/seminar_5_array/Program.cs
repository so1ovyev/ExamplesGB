// Задать массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найти сумму отрицательных и положительных элементов массива

//int minimalSum = 0;
//int maximalSum = 0;

//int length = ReadInt("Array length");
//int[] array = GetRandomArray(length, ReadInt("minValue"), ReadInt("maxValue"));

//PrintArray(array);
//CalculeteSum(array);

//Console.WriteLine($"Positive sum is {maximalSum}; Negative sum is {minimalSum}");

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length]; // Создаем новый массив длинной length
    Random random = new Random(); // Создаем объект класса Random, для экономии памяти

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // Заполняем случайнми элементами от min до max
        //array[i] = random.Next(minValue, maxValue + 1) + random.NextDouble();
        //+ random.NextDouble(); Добавляет от 0 до 1, 0.1, 0.2 и тд
    }
    return array;
}

//void CalculeteSum (int[] array)
//{
//
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] < 0) minimalSum += array[i]; 
//        else maximalSum += array[i];
//    }
//}

void PrintArray(int[] array) // Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]},");
    }
}

int[] ArrayReplacement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

//string NumberSearch (int[] array,int number)
//{
//    string result = string.Empty;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (number == array[i]) result = "Yes";
//        else result = "No";
//    }
//    return result;
//    Console.WriteLine(result);
//}

void FindNumber (int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            Console.WriteLine($"Number {find} is in array");
            return; // return; Завершает выполнение ф-ции
        }
    }
    Console.WriteLine($"Number {find} is NOT in array");
}

int FindingNumberElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count ++;           
        }
    }
    return count;
    //Console.WriteLine($"Number elements from {count}");
}

int[] SumFirstSecond(int[] array)
{
    int[] newArray = new int[array.Length/2 + 1]; //Получается на одну ячейку больше
    for (int i = 0; i < array.Length/2; i++)
    {
        newArray[i] = array[i] + array[array.Length - 1 - i];
    }
    if (array.Length / 2 != 0) newArray[array.Length / 2] = array[array.Length / 2]; 
    // Если не четное, заполняет среднюю ячейку
    return newArray;

}
void SumFirstSecondNew(int[] array)
{
    for (int i = 0; i < (array.Length / 2); i++)
    {
        System.Console.Write($"{array[i] + array[array.Length - i - 1]}, ");
    }
    if (array.Length % 2 != 0)
    {
        System.Console.WriteLine(array[array.Length / 2]);
    }
}


// Task32;
// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательныеб и наобарот.

//int length = ReadInt("Array length");
//int[] array = GetRandomArray(length, ReadInt("minValue"), ReadInt("maxValue"));
//
//PrintArray(array);
//Console.WriteLine();
//ArrayReplacement(array);
//PrintArray(array);

//Task33;
//Задать массив. Написать программу, которая определяет, присутствует ли заданное число в массиве.

//int length = ReadInt("Array length");
//int[] array = GetRandomArray(length, ReadInt("minValue"), ReadInt("maxValue"));
//int find = ReadInt("Desired number");
//
//PrintArray(array);
//Console.WriteLine();
//FindNumber(array, find);

//Task35
//Задать одномерный массив из 123 случайных чисел.
//Найти количество элементов массива, значения которых лежат в отрезке [10, 99]

//int length = ReadInt("Array length");
//int[] array = GetRandomArray(length, ReadInt("minValue"), ReadInt("maxValue"));
//
//
//PrintArray(array);
//Console.WriteLine();
//int count = FindingNumberElements(array);
//Console.WriteLine($"Number elements from {count}");

//Task37
//Найти произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, вторйо и предпоследний и тд.
//Результат записать в новом массиве

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, ReadInt("minValue"), ReadInt("maxValue"));

PrintArray(array);
Console.WriteLine();
SumFirstSecondNew(array);

//int[] newArray = SumFirstSecond(array); //Работает, но хуже второго варианта
//PrintArray(newArray); //Работает, но хуже второго варианта









