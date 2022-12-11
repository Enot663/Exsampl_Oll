// Вид 1 Ничего не возвращают и ничего не принимают
//void Method1()
{
    //Console.WriteLine("Автор.....");
}
//Method1();











// Вид 2 Ничего не возвращают но принимают некоторые аргументы
// void Method2(string msq)
// {
//     Console.WriteLine(msq);
// }
// Method2("текст сообщения");

// void Method21(string msq, int count)
// {
//     int i = 0;
//     while(i<count)
//     {
//         Console.WriteLine(msq); 
//         i++;
//     }
    
// }
// Method21("текст сообщения", 5);







// Вид 3 Что то возвращают но ничего не принимаюе.

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);












// Вид 4. Что то принимают и что то возвращают.

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(4, "FFF");
Console.WriteLine(res);
