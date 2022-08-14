//1 вид метода ничего не возвращает и ничего не принимает
void Method1() //ключевое слово void. В скобках нет аргуменнта
{
    Console.WriteLine("Автор ...."); //тело метода

}

//Method1(); //вызов метода, обязательно скобки

//вид 2 метод ничего не возращает, но может принимать аргументы

void Method2(string msg) //void - ключевое слово, Method2 - идентификатор, в скобках аргумент
{
    Console.WriteLine(msg);
}

//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //увеличение переменной на 1 наз-ся инкремент
    }
}
//Method21("Текст", 4); 
//Ctrl + c  - убрать зациклинность программы
//Method21(count:4, msg: "Новый текст"); // можно выводить с алгоритмами


//вид 3, методы что-то возвращают, но ничего не принимают
int Method3() //Обязательно указывать тип данных, который возращает, например int
{
    return DateTime.Now.Year; //return обязательно
}

int year = Method3(); //добавляем переменную, в которую положим результат
//Console.WriteLine(year);

//вид 4 методы, кот-е что-то принимают и что-то возвращают
// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = ""; //пустая строка или можно написать = String.Empty
//     while (i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

//вид 4 второй вариант реализации с циклом for

string Method4 (int count, string text)
{ 
    string result = String.Empty;
    for (int i = 0; i<count;  i++)
    {
            result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

//Пример использования цикла в цикле

