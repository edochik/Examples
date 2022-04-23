//поиск индекса
int [] array = { 15, 22, 34, 4, 52, 64, 4, 628, 92};

int n = array.Length;
int find = 4;

int index =0;

while(index < n)
{
   if(array[index] == find)
   {
       Console.WriteLine(index);
       break; // если несколько элементов в массиве одинаковых, находит первый индекс элемента и заканчивает операцию
   }
   //index = index + 1;
    index++;


}