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

//for (int i = 2; i <= 10; i++)
//{
//for (int j = 2; j <= 10; j++)
//{
//    Console.WriteLine($"{i} x {j} = {i * j}");
//  }
//Console.WriteLine();
//}

//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.

//string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//+ "ежели бы вас послали вместо нашего милого Винценгероде,"
//+ " вы бы взяли приступом согласие прусского короля. "
//+ "Вы так красноречивы. Вы дадите мне чаю?";
//Console.WriteLine(text);
//
//string Replace(string text, char oldValue, char newValue)
//{
//string result = String.Empty;
//
//int length = text.Length; //вычисляем длину строки
//
//for (int i = 0; i < length; i++)
//{
//if (text[i] == oldValue) result = result + $"{newValue}";
//else result = result + $"{text[i]}";
//}
//
//return result;
//}
//
//Console.WriteLine();
//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
//
//Console.WriteLine();
//string newText1 = Replace(newText, 'с', 'С');
//Console.WriteLine(newText1);
//
//Console.WriteLine();
//string newText2 = Replace(newText1, 'к', 'К');
//Console.WriteLine(newText2);

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 1, 5, 4, 2, 3, 2, 5, 7, 1, 1, 9 };

        void PrintArray(int[] array) //задаем метод для вывода массива на экран
        {
            int count = array.Length;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]} ");
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
                    if (array[j] < array[minPosition]) minPosition = j;
                }

                int temporary = array[i];// записываем значение из текущей рабочей позиции
                array[i] = array[minPosition];
                array[minPosition] = temporary;
            }
        }

        PrintArray(arr);
        SelectionSort(arr);

        PrintArray(arr);
    }
}