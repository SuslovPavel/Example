// метод заполнения массива и выведение на экран созданого массива и искомого числа (4)

void FillArray (int[] collection) //
 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;  // вместо 0 можно вписать (-1) тогда в случае если искомое число (например 444) не входит в массивто выводится -1

    while (index < count)
    {
       if (collection [index] == find)
       {
        position = index;
        break;                         // прерывание цикла после первой найденой 4ки
       } 
        
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);

array[4] = 4; // искуственно присвоили 4 на 4 и 6 индекс
array[6] = 4;

PrintArray(array);

Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine (pos);