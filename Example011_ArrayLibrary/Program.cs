void FillArray(int[] collection) // заполнение массива
{
    int length = collection.Length; //вытягиваем длинну массива
    int index = 0; // устанавливаем счетчик
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // выводим случайное значение
        index++;
    }
}

void PrintArray(int[] col) //выводим массив на экран
{
    int count = col.Length; // длинна массива
    int position = 0; // устанавливаем счетчик
    while (position < count)
    {
        System.Console.WriteLine(col[position]); //выводим на экран
        position++;
    }
}
int[] array = new int[10]; //устанавливаем длинну массива
FillArray(array);
PrintArray(array);