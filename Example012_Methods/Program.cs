// //1 вид метода ничего не возвращает и ничего не принимает
// void Method1() //ключевое слово void. В скобках нет аргуменнта
// {
//     Console.WriteLine("Автор ...."); //тело метода

// }

// //Method1(); //вызов метода, обязательно скобки

// //вид 2 метод ничего не возращает, но может принимать аргументы

// void Method2(string msg) //void - ключевое слово, Method2 - идентификатор, в скобках аргумент
// {
//     Console.WriteLine(msg);
// }

// //Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; //увеличение переменной на 1 наз-ся инкремент
//     }
// }
// //Method21("Текст", 4); 
// //Ctrl + c  - убрать зациклинность программы
// //Method21(count:4, msg: "Новый текст"); // можно выводить с алгоритмами


// //вид 3, методы что-то возвращают, но ничего не принимают
// int Method3() //Обязательно указывать тип данных, который возращает, например int
// {
//     return DateTime.Now.Year; //return обязательно
// }

// int year = Method3(); //добавляем переменную, в которую положим результат
// //Console.WriteLine(year);

// //вид 4 методы, кот-е что-то принимают и что-то возвращают
// // string Method4 (int count, string text)
// // {
// //     int i = 0;
// //     string result = ""; //пустая строка или можно написать = String.Empty
// //     while (i<count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }
// // string res = Method4(10, "asdf");
// // Console.WriteLine(res);

// //вид 4 второй вариант реализации с циклом for

// // string Method4 (int count, string text)
// // { 
// //     string result = String.Empty;
// //     for (int i = 0; i<count;  i++)
// //     {
// //             result = result + text;
// //     }
// //     return result;
// // }
// // string res = Method4(10, "z");
// // Console.WriteLine(res);

// //Пример использования цикла в цикле в виде таблицы умножения

// //  for (int i = 2; i<=10;  i++)
// //  {
// //     for(int j = 2; j<=10; j++)
// //    { Console.WriteLine($"{i}*{j} = {i*j}");
// //  }
// // Console.WriteLine();
// //  }




// //=====Работа с текстом
// // // Дан текст. В тексте нужно все пробелы заменить чёрточками,
// // // маленькие буквы “к” заменить большими “К”,
// // // а большие “С” маленькими “с”.


// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// string Replace (string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i]==oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
    
//     } 
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);



//Задача
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.


// int [] array = {1, 4, 2, 8, 4, 6, 155, 4, 3, 7, 8, 9, 0};
// void PrintArray (int [] array)
// {
//     int count = array.Length;
//     for (int i=0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }

// Console.WriteLine();
// }

// void SelectionSort(int [] array)
// {
//     for (int i = 0; i < array.Length-1; i++)
//     {
//         int minPosition = i; 
//         for (int j = i +1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) 
//             {minPosition = j;}
//         }


//         int temprory = array[i];
//         array[i]= array[minPosition];
//         array[minPosition] = temprory;
//     }

// }
// PrintArray(array);
// SelectionSort(array);

// PrintArray(array);