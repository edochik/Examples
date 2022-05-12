void Method1()// Вид1 непринимает ни каких аргументов и ничего не возвращает
{
    Console.WriteLine("Автор...");
}

//Method1();
//==============================================================================
void Method2(string msg) // Вид2 методы ни чего не возращают но могут принимать какие то аргументы(в скобках) 
{
    Console.WriteLine(msg); //именновые аргументы
}
// Method2(msg: "Текст сообщение");
//==============================================================================
void Method21(string msg, int count) //  метод выводит кол-во сообщений. 
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21(msg: "текст", count: 4);
//Method21(count: 4, msg: "новый текст");
//===================================================================================
//Вид3 Метод возвращает но ни чего не принимает

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);
//=================================================================================
//Вид4 метод что то принимает и что то возвращает
string Method4(int count, string text) // с помощью данного метода можно вывести текст, первое определяет кол-во второе какой текст
{
    int i = 0;
    string result = String.Empty; // result будет изначально пустой строкой

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//string res = Method4(10, "z"); // обращаемся к методу, определяем кол-во и текст который будет выводиться
//Console.WriteLine(res);

//===================================================================
string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)//1 иницилизация счётчика. 2. проверка условия.3. увеличение счётчика
    {
        result = result + text;
    }
    return result;
}

//string res = Method41(10, "Z");
//Console.WriteLine(res);

//====================================================
//цикл внутри цикла - закрашивать область в треугольнике/фигуре
//вывод таблицы умножения 2 на 2 и т.де с увеличением
/*for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{j}x{i} = {i * j}");
    }
}
*/
//=================================== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// мальнекие буквы "к" заменить большими "К"б
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "— Я думаю,   — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
//s[3]  //  r
/*
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;// сюда будем складывать результат. пустая строка String.Empty

    int length = text.Length; //получить длинну строки
    for (int i = 0; i < length; i++) //пробегаемся по всем строчкам
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|'); // используем сделанный метод 
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'K');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
*/

/*
int[] array = { 1, 5, 2, 4, 6, 2, 7, 5, 6 };

void PrintArray(int[] array)//Метод 4 печатает массив(принимает в себя значения и выводит)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // Метод который упорядочивает массив 4 Метод
{
    for (int i = 0; i < array.Length - 1; i++)// пробегаемся по всем элементам нашего массива к длинне нашего массива
    {
        int minPosition = i; // Ту позицию на которую смотрим и запоминаем эту позицию
        for (int j = i + 1; j < array.Length; j++) // ищем наш минимальный элемент(начинаем от не отсортированного кода i +1)
        {
            if (array[j] < array[minPosition]) minPosition = j; // сохраняем данную позицию
        }
        int temporary = array[i]; // Поменять местами позицю которую мы нашли
        array[i] = array[minPosition]; // в итою позицию укладываем элемент
        array[minPosition] = temporary; // в данный код кладем элемент который был временным
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);
*/