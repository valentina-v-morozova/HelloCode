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

int IndexOf(int[] collection, int find) //функция поиска номера элемента массива по значению
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //значение не найдено

    while (index < count)
    {
        if(collection[index] == find) //если на текущей позиции искомое значение
                {
            position = index; //запомнить номер позиции
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //устанавливаем длинну массива

FillArray(array);
//array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);