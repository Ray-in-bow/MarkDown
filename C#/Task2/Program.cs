// Task1
Console.Write("num: ");
string num1 = Console.ReadLine()!;
int num = int.Parse(num1);
if (num % 7 == 0 && num % 23 == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");


// Task2
Console.Write("X: ");
string x1 = Console.ReadLine()!;
int x = int.Parse(x1);
Console.Write("Y: ");
string y1 = Console.ReadLine()!;
int y = int.Parse(y1);
if (y > 0)
{
    if (x > 0)
        Console.Write("I");
    else
        Console.Write("II");
}
else
{
    if (x > 0)
        Console.Write("IV");
    else
        Console.Write("III");
}


// Task3
Console.Write("Num: ");
string Num1 = Console.ReadLine()!;
int Num = int.Parse(Num1);
if (Num / 10 >= Num % 10)
    Console.Write(Num / 10);
else
    Console.Write(Num % 10);


// Task4
Console.Write("N: ");
string n = Console.ReadLine()!;
int N = int.Parse(n);
while (N > 0)
{
    if (N > 9)
    {
        Console.Write(N % 10 + ", ");
    }
    else
    {
        Console.Write(N);
        N = 0;
    }
    N /= 10;
}