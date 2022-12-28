//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter a three-digit number");
int number = int.Parse(Console.ReadLine()!);
if (number > 100 && number < 1000)
{
    number = (number % 100) / 10;
    Console.WriteLine($"Second number: {number}");
}
else Console.WriteLine($"{number} not a three digit number!");





