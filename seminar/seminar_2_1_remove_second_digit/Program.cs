//Удалить вторую цифру трёхзначного числа
// 123 > 13
// 1.
// ГЛАВНАЯ ЗАДАЧА
// 100 <= n <= 999
// число, которое вводит юзер
// как выводить резуульта 
// 123 
// 13
// 123 -> 13
// 012
// -214: Abs(-214) = 214 -> 24
// -214: Abs(-214) = 214 -> -24
// 
// 2.
// 2.1. Метод, который -> Ввод числа
// 2.2. Метод, который -> Проверка числа на валидность
// 2.3. Метод, который -> Отковырять вторую цифру +++
// 2.4. Метод, который -> Распечать результат
// 2.5. Метод, который -> Декоратор для вывода
//
// 3. 
// ___
// abc = a*100 + b*10 + c 
// 456 = 4*100 + 5*10 + 6
// ___
//  ac = a*10 + c 
// 
// ДЕЛЕНИЕ  Целочисленное        14 div 5 => 2       int / int => int

//          Обычное              14 / 5 => 2.8       double / int = double
//                                                   int / double = double
//                                                   double / double = double

//          Остатком             14 mod 5 => 4       int % int => int
// ________________________________________________________________________________
// abc = value
// a = value div 100
// b = (value div 10) mod 10
// c = value mod 10







//int GetNumber(int value) 
//{
//    int a = value / 100;
//    int b = value / 10 % 10;
//    int c = value % 10;

//    return a * 10 + c;
//}
//WriteLine(GetNumber(924));  

int GetNumberFromUser() // 2.1.Метод, который->Ввод числа
{
    Console.Write("Введите число от 100 до 999: ");
    int temp = int.Parse(Console.ReadLine()); //int.Parse - конвертирует строку в число
    return temp;
}


bool IsValid(int number) // 2.2. Метод, который -> Проверка числа на валидность
{
        return number >= 100 && number <= 999; // and -> &&
    // if (number >= 100)
    // {
    //   if (number <= 999)
    //   {
    //     return true;
    //   }
    // }
    // return false;
}


int GetNumber(int value) // 2.3. Метод, который -> Убирает вторую цифру
{
    int a = value / 100;
    int b = value / 10 % 10;
    int c = value % 10;

    return a * 10 + c;
}


string GetText(int input, int output) // 2.4. Метод, который -> Распечать результат
{
    return input + " -> " + output;
}



//string Decorator(string text)
// 2.5. Метод, который -> Декоратор для вывода
//{
//Console.Clear();
//Console.ForegroundColor = ConsoleColor.Red;
//return text;
//}


//void Decorator2(string text)
//{
//Console.Clear();
//System.Console.WriteLine("❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️");
//ConsoleColor old = Console.ForegroundColor;
//Console.ForegroundColor = ConsoleColor.Red;
//System.Console.WriteLine(text);
//Console.ForegroundColor = old;
//System.Console.WriteLine("❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️");
//}

//void Task10()
//{
    //int value = GetNumberFromUser();

    //if (IsValid(value))
    //{
       // int result = GetNumber(value);
        //System.Console.WriteLine(GetText(value, result));
       // Decorator2(GetText(value, result));
  //  }
  //  else
  //  {
  //      System.Console.WriteLine("число кривое");
  //  }
//}

// =============================================================
//Task10();




