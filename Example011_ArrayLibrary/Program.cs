void FillArray(int[] collection)//метод создающий массив
{
    int length = collection.Length; // длина массива + название.Lenght
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);// создать 10 случайных чисел
        //index = index +1;
        index++;

    }


}

void PrintArray(int[] col) //метод печатающий массив void ни чего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find) // находим нужный элемент в массиве
{
    int count = collection.Length;//длина местода первого
    int index = 0;
    int position = -1; // если мы в массиве ищем не существующи элемент то будет 0, чтобы этого не было надо поставить -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //если в массиве одинакова цифра на разных индекса, то это останавливает на первом элементе
        }
        index++;

    }
    return position;
}

int[] array = new int[10];// создай массив в котором будет 10 элементов, нужно создать массив который его заполнит

FillArray(array); // обращение к методу заполняющему массив
array[4] = 4;
array[6] = 4;
PrintArray(array); // обращение к методу распечатывающему массив
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);

/// если искать элемент, который не сущестует, то позиция нидекса будет 0