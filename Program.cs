int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int count = int.Parse(Console.ReadLine());
Console.Write(a + " " + b);

for (int i = 2; i < count; i++)
{
    int c = a + b;
    Console.Write(" " + c);
    a = b;
    b = c;
}
Console.WriteLine();
