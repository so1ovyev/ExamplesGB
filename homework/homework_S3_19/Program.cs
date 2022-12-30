// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Console.WriteLine("Enter number: ");
//int number = int.Parse (Console.ReadLine()!);
//string numberString = number.ToString ();
////.ToString - превращает число в строку
//int i = 0;
//string result = string.Empty;
//while (i < numberString.Length / 2)
//{
//    if (numberString[i] == numberString[numberString.Length - 1 - i])
//    {
//        result = "It's a palindrom";
//        i++;
//    }
//    else result = "It's not a palindrom"; break;
//}
//Console.WriteLine(result);

//Вариант 2

//Console.WriteLine("Enter number: ");
//string number = Console.ReadLine();
//int i = 0;
//string result = string.Empty;
//while (i < number.Length / 2)
//{
//    if (number[i] == number[number.Length - 1 - i])
//    {
//        result = "It's a palindrom";
//        i++;
//    }
//    else result = "It's not a palindrom"; break;
//}
//Console.WriteLine(result);

//Вариант 3 (Работает, но что-то не нравится)

Console.WriteLine("Enter number: ");
string number = Console.ReadLine();
string result = string.Empty;

for (int i = 0; i < number.Length / 2; i++)
{
    if (number[i] == number[number.Length - 1 - i])
    result = "It's a palindrom";
    else result = "It's not a palindrom"; break;
}
Console.WriteLine(result);

