Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine());

switch (i)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Субботу"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Нет дня недели! Введите число от 1 до 7"); break;
}
