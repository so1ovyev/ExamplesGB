// Напишите программу, которая принимает на вход три числа и выдает максимальное их этих чисел.
// 2, 3, 7  > 7
// 44, 5, 78 > 78
// 22, 3, 9 > 22

// 1. Запросить у пользователя 3 числа +
// 2. Сравнить 3 числа между собой
// 3. Вывести результат

Console.Write ("Введите число А: ");                        
int numberA = int.Parse(Console.ReadLine()!); //! подтверждение, убирает NULL ошибку

Console.Write ("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.Write ("Введите число C: ");
int numberC = int.Parse(Console.ReadLine()!);

int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine($"{numberA}, {numberB}, {numberC} > {max}");
