//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.

Console.WriteLine ("Enter number");
int N = int.Parse(Console.ReadLine());
int b = 0;
if (N > 100)
{
    while (N > 1000) N = N / 10;
    Console.WriteLine($"Third digit {b = N % 10}");
}
else Console.WriteLine ("No third number!");