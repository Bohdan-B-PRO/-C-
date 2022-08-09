//МЕТОДЫ ЕОТОРЫЕ НЕ ЧЕГО НЕ ВООЗВРАЩАЮТ!
//Вид 1. Метод нечего не принимает и не чего не воозвращает!
/*
void Method1()
{
    Console.WriteLine("Автор - Богдан Сергеевич Буржулюк! ");
}
Method1();
*/

//Вид 2.Метод не чего не воозвращает но могут принимать документы!
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения ");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++; //Добовление на единицу называют - инкрементом, а уменьшение на единицу - теткриментом!
    }
}
Method21(msg: "Текст ", count: 4);

Method21(count: 4, msg: "Новый текст");
*/
//МЕТОДЫ КОТОРЫЕ ЧТО-ТО ВООЗВРАЩАЮТ!
//Вид 3.Метод чтот-то воозвращают но ничего не принимают!
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

//Вид 4.Метод что-то принимает и что-то воозвращает!
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
*/
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result += text;
    }
    
    return result;
}


string res = Method4(10, "Z ");
//Console.WriteLine(res);

*/
/*
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/
/*
string text = "-Я думаю, сказал князъ, улыбаясь, -что,"
            + "ежели бы вас послали вместо милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwrty"
//              012
//s[3] // г

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int Length = text.Length;
    for(int i = 0; i < Length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[]array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectioSort(int[]array)
{
    for(int i =0; i < array.Length ; i++)
    {
        int minPosition = i;
        
        for(int j = i + 1; j < array.Length - 1; j++)
        {
            if(array[i]  < array[minPosition])minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectioSort(arr);
PrintArray(arr);
