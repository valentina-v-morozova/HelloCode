Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 20,
    xc = 80, yc = 20;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; //случайная точка

int count = 0; //обнуляем счетчик

while(count < 10000) //пока счетчик меньше задонного к-ва раз
{
    int what = new Random().Next(0, 3); //генерируем случайное число [0;3)
    if (what == 0) // если =0, записываем координаты середины отрезка с вершиной xa
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    
    if (what == 1) // если =1, записываем координаты середины отрезка с вершиной xb
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2) // если =1, записываем координаты середины отрезка с вершиной xc
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y); //ставим точку в заданную позицию
    Console.WriteLine("+");
    count = count + 1; //увеличиваем счетчик
}