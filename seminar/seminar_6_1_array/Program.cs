//Task39();
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый на последнем)

int ReadInt (string arg)
{
    Console.WriteLine ($"Input {arg}");
    return int.Parse(Console.ReadLine());
}

int[] RandomArray (int length, int minValue, int maxValue)
{
    int[] array= new int[length];
    Random random= new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}; ");
    }
}

int[] ReversalArray(int[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newarray[array.Length - 1 - i] = array[i];
    }
    return newarray;
}

void Task39()
{
    int[] array = RandomArray(ReadInt("length"), ReadInt("minValue"), ReadInt("maxValue"));
    PrintArray(array);
    Console.WriteLine();
    int[] newarray = ReversalArray(array);
    PrintArray(newarray);
}

//Task40();
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Сумма 2х сторон всегда больше третьей

//int ReadInt (string s)
//{
//    Console.WriteLine($"Input {s}");
//    return int.Parse(Console.ReadLine());
//}

void CheckTriangle(int a, int b, int c)
{
    string result = string.Empty;
    if (a+b > c && b+c > a && a+c > b) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}

void Task40()
{
    int a = ReadInt("A");
    int b = ReadInt("B");
    int c = ReadInt("C");
    CheckTriangle(a, b, c);
}

//Task42();
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 - 101101
//3 - 11
//2 - 10
//Делим число на 2, если есть остаток - 1, если нет - 0


void DecimalToBinary (int number)
{
    string result = string.Empty;
    while (number != 0)
    {
        result += number % 2;
        number /= 2;
    }
    string Revers(string result) //Разворот, можно через массив
    {
        char[] array = result.Reverse().ToArray();
        string newresult = string.Empty;
        foreach (char c in array)
        newresult += c;
        return newresult;
    }
    Console.WriteLine(Revers(result));
}

void Task42()
{
    int number = ReadInt("number");
    DecimalToBinary(number);  
}

//Task44();
//Вывести первые N чисел Фибоначи. Первые числа 0 и 1
//f(0) = 0
//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f (n-2)


int[] Array (int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

void FibonacciPrint (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i} = {array[i]}");
    }
}

void Task44()
{
    int N = ReadInt("N");
    int[] array = Array(N);
    FibonacciPrint(array);
}

//Task45();
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] CloneArray (int[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < newarray.Length; i++)
    {
        newarray[i] = array[i];
    }
    return newarray;
}

void Task45()
{
    int[] array = RandomArray(ReadInt("length"), ReadInt("minValue"), ReadInt("maxValue"));
    PrintArray(array);
    Console.WriteLine();    
    int [] newarray = CloneArray(array);
    PrintArray(newarray);
}


//Создание массива из символов. min - 1, max - 1000
TestArraChar();

char[] CharArray(int length, int min, int max)
{
    char[] array = new char[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (char)random.Next(min, max + 1);
    }
    return array;
}

void PrintChearArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void TestArraChar()
{
    char[] array = CharArray(ReadInt("length"), ReadInt("min"), ReadInt("max"));
    PrintChearArray(array);

}