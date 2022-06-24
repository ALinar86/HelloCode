Console.Write("Input number: ");
int  N = Convert.ToInt32(Console.ReadLine());
int i;
for (i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}