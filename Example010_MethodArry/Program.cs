// Имеется ономерный массив array из n элементов, требуется
// найти элемент массива равный find.
// 1. Установить счетчик index в позицию 0 
// 2. Если array[index] = find алгоритм завершл работу успешно.
// 3. Увеличить index на 1.
// 4. Если index < n переходим к шагу 2. В противном случае 
// алгоритм завершил работу безуспешно.
Console.Clear();

int[] array = {19, 72, 83, 24, 185, 36, 97, 28};

int n = array.Length;
int find = 185;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1
    index++;
}


