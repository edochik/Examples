//поиск индекса
int[] array = { 1, 2, 4, 5, 4, 7, 18, 9, };

int n = array.Length;// длина или кол-во массива
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {

        Console.WriteLine(index);

    }
    index++;
}