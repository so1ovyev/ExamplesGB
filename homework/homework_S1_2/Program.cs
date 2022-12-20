// Напишите программу, которая на входе принимает два числа и выдаёт, какое число больше, а какое меньше.
// а = 5; b = 7 > max = 7
// a = 2; b = 10 > max = 10
// a = -9; b = -3 > max = -3

// 1. Запросить от пользователя 2 числа, numberA, numberB
// 2. Сравнить 2 числа
// 3. Вывести результат сравнения

Console.Write ("Введите число А: ");                        
int numberA = int.Parse(Console.ReadLine()!);

Console.Write ("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);



if(numberA > numberB) 
{
   Console.WriteLine($"max = {numberA}");
}
else
{
    Console.WriteLine($"max = {numberB}");
}
