// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

void Task29()
{
    //Console.WriteLine("Array");
    int[] array = Array(Readint("array length"));
    Console.WriteLine(ArrayToString(array));
}

int Readint(string argument)
{
    Console.WriteLine($"Input {argument}: "); 
    return int.Parse(Console.ReadLine());
}

int[] Array(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Readint($"elements {i}");
    }
    return array;
}

string ArrayToString(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]} ";
    }
    return result;    
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452-> 11
//82-> 10
//9012-> 12

void Task27()
{
    string number = Readint("Number").ToString();
    int sum = 0;
    for (int i = 0; i <= number.Length - 1; i++)
    {
        sum += int.Parse(number[i].ToString());
    }
    Console.WriteLine(sum);
}

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16

void Task25 ()
{
    int A = Readint("Number A");
    int B = Readint("Number B");
    double degree = 0;

    for (int i = 1; i <= B; i++)
    {
        degree = Math.Pow(A, i);
    }
    Console.WriteLine($"Number {A} to the power of {B} = {degree}");
}
