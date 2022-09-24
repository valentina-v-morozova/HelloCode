// Вид 1 (не принимают данные, не возвращают данные)

//void Method1()
//{
//Console.WriteLine("Автор ...");
//}

//Method1(); //вызов название + ()

// Вид 2 (принимают аргументы, не возвращают данные)
//    void Method2(string msg)
//{
//  Console.WriteLine(msg);
//}
//Method2();

//void Method21(string msg, int count)
//{
//int i = 0;
//while (i < count)
//{
//  Console.WriteLine(msg);
//i++;
//}
//}
//Method21("Text", 4);

//Вид 3 (не принимает аргументы, возвращает данные)

//int Method3()
//{
//return DateTime.Now.Year;
//}
//
//int year = Method3();
//Console.WriteLine(year);

//Вид 4 (принимают аргументы, возвращают данные)

//string Method4(int count, string c)
//{
//int i = 0;
//string result = String.Empty;
//
//while (i < count)
//{
//result = result + c;
//i++;
//}
//return result;
//}
//
//string res = Method4(10, "asdf ");
//Console.WriteLine(res);

//string Method41(int count, string c)
//{
//  string result = String.Empty;
//for (int i = 0; i < count; i++)
//{
//result = result + c;
//}
//return result;
//}
//
//string res = Method41(10, "asdf ");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
Console.WriteLine();
}