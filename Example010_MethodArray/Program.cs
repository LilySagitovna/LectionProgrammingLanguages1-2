//Имеется одноименный массив array из n элементов
//требуется найти элемент массива равный find (задает пользователь)

//Алгоритм
// 1Установить счетчик index в позицию 0
// 2Ecли array[index]=find? алгоритм завершил работу успешно
// 3Увеличить index на 1
// 4Если index<n то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.

int[] array = { 1, 12, 31, 4, 15, 16, 18, 17, 18 };
int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}