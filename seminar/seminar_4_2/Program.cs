//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

string number = ReadInt("number").ToString();

Console.WriteLine($"Количество цифр: {number.Length}");
Console.ReadLine();
//number.Length;