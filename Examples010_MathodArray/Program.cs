// Требуется найти элемент массива, равный find

int[] array = { 1,21,33,14,21,16,17,81 };

int n = array.Length;
int find = 21;
int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
         break;
   
    }
    
    // index = index + 1;
    index++;
}

