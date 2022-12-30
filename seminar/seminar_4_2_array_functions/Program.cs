int Readint(string argument)
{
    Console.WriteLine($"Input {argument}: "); //
    return int.Parse(Console.ReadLine());
}

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
void Task28()
{
    int number = Readint("number: ");
    int work = 1;
    for (int i = 1; i <= number; i++)
    {
        work *= i;
    }
    Console.WriteLine(work);
}

// Показывает количество цифр в веденном числе
void TaskN()
{
    int number = Readint("number: ");
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    Console.WriteLine(count);
}

//Напишите программу, которая выводит массив из 8 элементов, заполеннный нулями и единицами в случайном порядке.
void Task30()
{
    Console.WriteLine("Array");

    int[] array = GetArray(Readint("array length"));

    //Console.WriteLine(GetArray(array[1]));
    Console.WriteLine(ArrayToString(array));
}

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

string ArrayToString(int[] array)
{
    string result = string.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}, ";
    }

    return result;
}

//Console.WriteLine("From 1 to N");
//Task28();
//Console.WriteLine("Number of digits");
//TaskN();
//Task30();

//Метод создающий массив и заполняющий его случайными числами
//int[] array = new int[Readint("length")];
//Random random = new Random();
//
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 2);
//}
//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write($"{array[i]} ");
//}

//Метод создающий массив и заполняющий его числами от пользователя
//int[] array = new int[Readint("length")];
//
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = Readint($"elements {i}");
//}
//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write($"{array[i]} ");
//}



