//Задача 1

//int number;
//Console.WriteLine("Введите целое число: ");
//number = Convert.ToInt32(Console.ReadLine());
//if (number % 3 == 0)
//    Console.WriteLine("Число делится на 3 без остатка");
//else
//    Console.WriteLine("Число не делится на 3 без остатка");


//Задача 2

//int number;
//Console.WriteLine("Введите целое число:");
//number = Convert.ToInt32(Console.ReadLine());
//if (number % 5 == 2 | number % 7 == 1)
//    Console.WriteLine("Число удовлетворяет условию");
//else
//    Console.WriteLine("Число не удовлетворяет условию");


//Задача 3

//int number;
//Console.WriteLine("Введите целое число:");
//number = Convert.ToInt32(Console.ReadLine());
//bool s = (number % 4 == 0) && (number >= 10);
//if (s)
//    Console.WriteLine("Число удовлетворяет условию");
//else
//    Console.WriteLine("Число не удовлетворяет условию");


//Задача 4

//int number;
//Console.WriteLine("Введите целое число: ");
//number = Convert.ToInt32(Console.ReadLine());
//if (number >= 5 && number <= 10)
//    Console.WriteLine("Число входит в диапозон от 5 до 10 включительно");
//else
//    Console.WriteLine("Число не входит в диапозон");


//Задача 5

//Console.WriteLine("Введите 4-х значное число:"); string user = Console.ReadLine();
//if (user.Length <= 4)
//{
//    int f = int.Parse(user.Substring(user.Length - 4, 1));
//    if (f == 1)
//        Console.WriteLine("В данном числе 1 тысяча.");
//    else
//        Console.WriteLine($"В данном числе {f} тысяч(и).");
//}
//else
//    Console.WriteLine("Введено некорректное число.");


//Задача 6

//Console.WriteLine("Введите число в десятичной форме:");
//string user = Console.ReadLine();
//int.TryParse(user, out int decimalNumber);
//string octalNumber = Convert.ToString(decimalNumber, 8);
//if (octalNumber.Length >= 2)
//{
//    char secondFromRight = octalNumber[octalNumber.Length - 2];
//    Console.WriteLine($"Вo введенном числе вторая справа цифра в восьмеричном представлении: {secondFromRight}");
//}   
//else
//    Console.WriteLine("Введенное число не имеет восьмеричного представления с двумя цифрами.");


//Задача 7

//Console.WriteLine("Введите число в десятичной форме:"); 
//if (int.TryParse(Console.ReadLine(), out int decimalNumber))
//{
//    int BitFromRight = (decimalNumber >> 2) & 1;
//    Console.WriteLine($"Третий бит справа в двоичном представлении:" + BitFromRight);
//}
//else
//    Console.WriteLine("Введено некорректное число.");


//Задача 8

//Console.WriteLine("Введите число в бинарном представлении:");
//string user = Console.ReadLine();
//if (IsBinaryNumber(user))
//{
//    int binaryNumber = Convert.ToInt32(user, 2);
//    int result = binaryNumber | (1 << 2);
//    Console.WriteLine($"Число после установки третьего бита: {result} (в бинарном представлении: {Convert.ToString(result, 2)})");
//}
//else
//    Console.WriteLine("Введено некорректное бинарное число.");
//    static bool IsBinaryNumber(string input)
//    {
//        foreach (char c in input)
//        {
//            if (c != '0' && c != '1')
//            {
//                return false;
//            }

//        }
//        return true;
//    }



//Задача 9

//Console.WriteLine("Введите число в бинарном представлении:");
//string user = Console.ReadLine();
//if (IsBinaryNumber(user))
//{
//    int binaryNumber = Convert.ToInt32(user, 2);
//    int result = binaryNumber & ~(1 << 3);
//    Console.WriteLine($"Число после установки 4го бита в бинарном представлении: {Convert.ToString(result, 2)}");
//}

//else
//    Console.WriteLine("Введено некорректное бинарное число."); 
//static bool IsBinaryNumber(string input)
//{
//    foreach (char c in input)
//    {
//        if (c != '0' && c != '1')
//        {
//            return false;
//        }
//    }
//    return true;
//}



//Задача 10

//Console.WriteLine("Введите число в бинарном представлении:"); 
//string user = Console.ReadLine();
//if (IsBinaryNumber(user))
//{
//    int binaryNumber = Convert.ToInt32(user, 2);
//    int result = binaryNumber ^ (1 << 1);
//    Console.WriteLine($"Число после инверсии второго бита в бинарном представлении:{Convert.ToString(result, 2)}");
//}

//else
//    Console.WriteLine("Введено некорректное бинарное число."); 
//static bool IsBinaryNumber(string input)
//{
//    foreach (char c in input)
//    {
//        if (c != '0' && c != '1')
//        {
//            return false;
//        }

//    }
//    return true;
//}

        








