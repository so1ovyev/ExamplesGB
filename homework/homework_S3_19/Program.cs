// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter number: ");
int number = int.Parse (Console.ReadLine()!);
string numberString = number.ToString ();
//.ToString - превращает число в строку
int i = 0;
string result = string.Empty;
while (i < numberString.Length / 2)
{
    if (numberString[i] == numberString[numberString.Length - 1 - i])
    {
        result = "It's a palindrom";
        i++;
    }
    else result = "It's not a palindrom"; break;
}
Console.WriteLine(result);

