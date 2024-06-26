for (int i = 1; i < 100; i++)
{
    Console.Write(i + "\t");
    if (i % 3 == 0) Console.Write("fizz");
    if (i % 5 == 0) Console.Write("buzz");
    Console.Write("\n");
}