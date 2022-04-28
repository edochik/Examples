//Вид1 ни чего не принимаю и ни чего не возвращают
/*void Method1()
{
    Console.WriteLine("Автор ...");

}
Method1();*/

//Вид2 ни чего не возращают но могут принимать аргументы 
void Metho2(string msg)
{
    Console.WriteLine(msg);
}
//Metho2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("Текст", count: 4);
//Method21(count: 4, msg:"новый текст");

//вид3 чтото возвращает аргументы не принимает
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид4 что то принимают и чтото возращают.
string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}+{i * j}");
    }
    Console.WriteLine();
}

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            0123456
// s [3] // r 

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);

/*int[] arr = { 1, 4, 5, 1, 6, 4, 6 };


void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/
/*
int[] arr = new int[8];//заполнить массив, первыми двумя цифрами
void Printarr(int[] arr)
{
    int lenght = arr.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}

Printarr(arr);*/


int[] arr = new int[8];//заполнить массив, первыми двумя цифрами
void Printarr(int[] arr)
{
    int lenght = arr.Length;
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(-9, 9);//заполнить массив 0 и 1
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Printarr(arr);
