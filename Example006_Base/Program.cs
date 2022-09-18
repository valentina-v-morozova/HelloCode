int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write(a);
Console.Write(" ");
Console.Write(b);
Console.Write(" ");
Console.Write(c);
Console.Write(" ");
Console.Write(d);
Console.Write(" ");
Console.WriteLine(e);
Console.Write("max = ");
Console.Write(max);