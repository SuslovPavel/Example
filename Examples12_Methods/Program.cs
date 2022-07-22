// 1  Метод ничего не возвращает ничего не принимает

void Method1()
{
    Console.WriteLine("Автор");
}
//Method1();

// 2 Метод ничего не возвращает но может принимать аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i=0;
    while( i< count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст",4); // (count:4, msg; "Текст" )

// 3 Метод который возвращает но не принимает

int Method3()
{
    return DateTime.Now.Year;
}
//int yaer = Method3();
//Console.WriteLine(yaer);

// 4 Метод который и возвращает и принимает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i <count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string result = Method4(10, " asdf ");
//Console.WriteLine(result);

// 4.1 Метод который и возвращает и принимает с циклом " for "

string Method41(int count, string text)
{
    
    string result = String.Empty;
    for (int i = 0; i< count; i++)  // инициализация счетчика, проверка условий, инкремент
    {
        result = result + text;
    }
    return result;
}
//string result = Method41(10, " asdf ");
//Console.WriteLine(result);


//     Пример Цикл в Цикле     //

void Method5()
{

    for (int i=2; i<=10; i++)
    {
        for (int j= 2; j<=10; j++)
    {
        Console.WriteLine ($"{i}x{j}={i*j}");  // способ интерполяции строк
    }
        Console.WriteLine();                  // строка для разрыва между столбцами
    }
}
//Method5();


