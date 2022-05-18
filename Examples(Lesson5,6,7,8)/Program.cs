//************************Собрать строку с числами от a до b, a <= b***************************************

/*
string NumbersFor(int a, int b)// итеративныйI(цикличный) подход   plan - do  - ceck - act cycle
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}
string NumbersRec(int a, int b) //рекурсия
{
    if (a <= b) return $"{a}" + NumbersRec(a + 1, b);
    else return String.Empty;
}
// Самостоятельная работа, додумать чтобы был метод меньше, else переписать иначе.
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

//Задача: Собрать строку с числами от a до b, a >= b

string NumbersFor(int a, int b)// итеративныйI(цикличный) подход   plan - do  - ceck - act cycle
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i}";
    }
    return result;
}
string NumbersRec(int a, int b) //рекурсия
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a}";
    else return String.Empty;
}
// Самостоятельная работа, додумать чтобы был метод меньше, else переписать иначе.
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

*/
//************************************Сумма чисел от 1 до n**********************************
/*
int SumFor(int n) //итеративный способ
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n) // рекурсия
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
*/
//****************************************факториал числа**************************************
/*
int FactorialFor(int n)//итеративный подход
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)//рекурсия
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));
*/
//**************************************Вычислить a в натуральной степени n************************
/*
int PowerFor(int a, int n)//итеративный подход
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)//рекурсия
{
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a; //тернарный оператор все то же самое только в одну строчку 
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}



// Базовая математика которая пригодится всем
// Степени
// 2(3) * 2 (5) = (2)8               a(m) * a(n) = a(m+n) - то что в скобках степени
// 2(12) = (2(2))(6)                 (a(m)n) = a (m*n) - то что в скобках степени

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));
*/

/*
Перебор слов

В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в". Покажите все слова,
состоящие из Т букв, которые можно простроить из букв этого алфавита.
*/

char[] s = { 'а', 'и', 'с', 'в' };
/*
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)//однобуквенные слова
{
    for (int i = 0; i < count; i++)//двухбуквенные слова
    {
        for (int i = 0; i < count; i++)//трехбуквенные слова
        {
            for (int i = 0; i < count; i++)//четырехбуквенные слова
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
                }
            }
        }
    }
}
*/
/*
int n = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);
*/

//******************************работа с директориями в компьютере
/*
string path = "/Users/Егор/Desktop/GeekBrains/1 четверть/Знакомство с языками программирования (семинары)/HomeWork6";//путь с чем должны работать
DirectoryInfo di = new DirectoryInfo(path); //работать с директориями
System.Console.WriteLine(di.CreationTime); //время создания 
FileInfo[] fi = di.GetFiles();// какие внутри содержатся файлы, для этого нужен массив (класс)

for (int i = 0; i < fi.Length; i++) // пробегается по папке и показывает, какие есть файлы
{
    System.Console.WriteLine(fi[i].Name);
}
*/
/*
//описываем рекурсию
void CatalogInfo(string path, string indent = "")//первый аргумент путь к текущей папке, второй аргумент отступы для того чтобы видеть структуру папки
{
    DirectoryInfo catalog = new DirectoryInfo(path);//получаем информацию по деректории в которую вошли

    DirectoryInfo[] catalogs = catalog.GetDirectories();//получаем массив всех файлов находящихся в папке пробегаем по ним
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}"); //выводим информацию о текущем каталоге
        CatalogInfo(catalogs[i].FullName, indent + " "); //рекурсивно смотрим еще раз папочки полученные на этапе массива
    }
    FileInfo[] files = catalog.GetFiles();//получим весь список файлов текущего католога

    for (int i = 0; i < files.Length; i++)//покажим текущий список
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"/Users/Егор/Desktop/GeekBrains/1 четверть/Знакомство с языками программирования (семинары)/HomeWork6";
CatalogInfo(path);
*/
//********************************************игра в пирамидки***********************
//рекурсия для пирамидок
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)//with - шпиль рабочий,on - шпиль на котором пирамидка должна оказаться, some - название промежуточного шпиля, count - кол-во блинов у нас есть
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);

}

Towers();
*/


//Обход разных структур
//Бинарное дерево
/*
string emp = String.Empty;
string[] tree = { "emp", "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3", };

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos; //левое под дерево
        int right = 2 * pos + 1; // правое под дерево
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);//можно поменять местами и это будет у же другой обход
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

InOrderTraversal();
*/

// время подсчета в рекурсии дольше

/*
decimal fRec = 0;
decimal fIte = 0;
decimal FibonacciRecursion(int n)//рекурсивный способ
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}
decimal FibonacciIteration(int n)// итерационный метод числа фибоначчи
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 0; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

Console.ReadLine();

DateTime dt = DateTime.Now;
for (int n = 10; n < 30; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fRec = {fIte.ToString("### ### ###"),-15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();

Console.ReadLine();
dt = DateTime.Now;
for (int n = 10; n < 30; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
    fRec = 0;
}
Console.WriteLine();
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
*/

