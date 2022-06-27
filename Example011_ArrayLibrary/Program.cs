void FillArray(int[] collection) //метод для заполнения массива случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)   //метод который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)  //метод отличный от войд - нахождение нужного нам индекса массива с помощью элемента
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position=index;
            break;
        }
            index++;

    }
    return position;

}

int[] array = new int[10]; //создай новый массив в котором будут 10 элементов

// void - метод который не возвращает значение, не используется оператор return

FillArray(array); //заполнил наш массив случайными числами
array[4]=4;
array[6]=4;
PrintArray(array); // распечатал наш массив

System.Console.WriteLine();

int pos=Index0f(array, 444);
System.Console.WriteLine(pos);