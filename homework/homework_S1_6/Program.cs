//Напишите программу, которая на вход принимает число и выдаё, является ли число чётным 
//4 > да
//-3 > нет
//7 > нет

Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if(number % 2 == 0) 
{
   Console.WriteLine($"{number} > да, число чётное");
}
else
{
    Console.WriteLine($"{number} > нет, число не чётное");
}

