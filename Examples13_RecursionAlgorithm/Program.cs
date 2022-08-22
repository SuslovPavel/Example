﻿// string[,] table = new string[2,5];                    // Пример сщздания двумерного массива
// table[1,2] = "слово";

// for(int rows = 0; rows< 2; rows++)                 // создаёт переменную для строк
// {
//     for(int colums = 0; colums< 5; colums++)       // создаёт переменную для столбцов
//     {
//         Console.Write($"-{table[rows,colums]}-");  // обращение к эл-там массива через имя массива , индекс строки и индекс столбца
//     }
//     Console.WriteLine();                           //  перемещает печать на новую строку после заполнения  столбцов 

// }

void PrintArray(int[,] matr) // Печатает массив
{
    for (int i = 0; i < matr.GetLength(0); i++)         // создаёт переменную для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)     // создаёт переменную для столбцов
        {
            Console.Write($"{matr[i, j]} ");            // обращение к эл-там массива через имя массива , индекс строки и индекс столбца
        }
        Console.WriteLine();                            // перемещает печать на новую строку после заполнения 4х столбцов 
    }
}

void FillArray(int[,] matr)  // Заполняет массив случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)         // создаёт переменную для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)     // создаёт переменную для столбцов
        {
            matr[i, j] = new Random().Next(1, 10);          // рандомно заполняет массив числами от 1 до 9
        }

    }
}

int[,] pic = new int[,]    //  рисунок палец вверх
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)         // создаёт переменную для строк
    {
        for (int j = 0; j < image.GetLength(1); j++)     // создаёт переменную для столбцов
        {
            if (image[i, j] == 0) Console.Write($" ");       // нули заменяет пробелами
            else Console.Write($"+");                    // единицы заменяет плюсами
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)   // РЕКУРСИЯ метод содержит алгоритм по закрашиванию какой либо области
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);    // метод который вызывает сам себя и проверяет по осям x и y занят эл-т или нет 
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

double Factorial(int n)   // Метод нахождения факториала
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);

}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}


///    Числа ФИБОНАЧИ f(n) = f(n-1) + f(n-2) где f(1)=1 и f(2)=1    ///

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);   // запускает метод внутри метода
}
Console.WriteLine();
Console.WriteLine("число фибоначи ");
for (int i = 1; i < 41; i++)              // вычисляет число фибоначи до 40
{
    Console.Write($"f({i}) = {Fibonacci(i)} ");      
}
Console.WriteLine();



int[,] matrix = new int[3, 4];                          // глобальная переменная в виде двумерного массива
PrintArray(matrix);                                     // вызов метода
FillArray(matrix);                                      // вызов метода для заполенения массива
Console.WriteLine();                                    // пустая строка
PrintArray(matrix);                                     // показывает уже заполненый массив методом FillArray

PrintImage(pic);                                        // запускает метод печать "пальца вверх"
FillImage(13, 13);                                       // запускает метод заполнения "палец вверх" / (13.13) точка отсчёта для заполнения рисунка
PrintImage(pic);                                        // выводит на консоль заполненый рисунок