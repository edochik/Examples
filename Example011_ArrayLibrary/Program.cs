void FillArray(int[] collection) // наполняет массив элементами
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;

    }
}

void PrintArray(int[] col)// Метод который печатает массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)// 
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
        return position;
    }
}

int[] array = new int[10]; // создай новый массив в котором будет 10 элементов (изначально он будет заполнен нулями)

FillArray(array);//заполнил данный массив
PrintArray(array);//распечатал массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
