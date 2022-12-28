// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.


Console.WriteLine("enter the number of the day of the week: ");
int day = int.Parse(Console.ReadLine()!);
string text = "Not a day of the week";
if (day >= 1 && day <= 5) text = "No";
if (day == 6 || day == 7) text = "Yes";
Console.WriteLine(text);