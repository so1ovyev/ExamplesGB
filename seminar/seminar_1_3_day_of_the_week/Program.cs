//Певое решение, совместное.

//Console.WriteLine ("Введите число от 1 до 7: ");

//int day = int.Parse(Console.ReadLine());

//string s = "Не день недели! ";

//if (day == 1)
//{
//    s = "понедельник";
//}
//else if (day == 2)
//{
//    s = "вторник";
//}
//else if (day == 3)
//{
//    s = "среда";
//}
//else if (day == 4)
//{
//    s = "четверг";
//}
//else if (day == 5)
//{
//    s = "пятница";
//}
//else if (day == 6)
//{
//    s = "субботу";
//}
//else if (day == 7)
//{
//    s = "воскресенье";
//}
//Console.WriteLine(s);

//Решение преподавателя
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